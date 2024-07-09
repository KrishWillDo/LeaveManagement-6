using AutoMapper;
using LeaveManagement_6.Constants;
using LeaveManagement_6.Contracts;
using LeaveManagement_6.Data;
using LeaveManagement_6.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagement_6.Repository
{
    public class LeaveAllocationRepository : GenericRepository<LeaveAllocation>, ILeaveAllocationRepository
    {
        private readonly ApplicationDbContext dbContext;
        private readonly UserManager<Employee> userManager;
        private readonly ILeaveTypeRepository leaveTypeRepository;
        private readonly IMapper mapper;

        public LeaveAllocationRepository(ApplicationDbContext dbContext,
                                        UserManager<Employee> userManager,
                                        ILeaveTypeRepository leaveTypeRepository,
                                        IMapper mapper) : base(dbContext)
        {
            this.dbContext = dbContext;
            this.userManager = userManager;
            this.leaveTypeRepository = leaveTypeRepository;
            this.mapper = mapper;
        }

        public async Task<bool> AllocationExists(string employeeId, int leaveTypeId, int period)
        {
            return await dbContext.LeaveAllocations.AnyAsync(x => x.EmployeeId == employeeId
                                                         && x.LeaveTypeId == leaveTypeId
                                                         && x.Period == period);
        }

        public async Task<EmployeeLeaveAllocationVM> GetEmployeeLeaveAllocations(string employeeId)
        {
            var allocation = await dbContext.LeaveAllocations
                                      .Include(x => x.LeaveType)
                                      .Where(x => x.EmployeeId == employeeId).ToListAsync();


            var employee = await userManager.FindByIdAsync(employeeId);

            var employeeLeaveAllocations = mapper.Map<EmployeeLeaveAllocationVM>(employee);
            employeeLeaveAllocations.LeaveAllocationVM = mapper.Map<List<LeaveAllocationVM>>(allocation);

            return employeeLeaveAllocations;

        }
        public async Task<EditLeaveAllocationVM> GetEmployeeLeaveAllocation(int Id)
        {
            var allocation = await dbContext.LeaveAllocations
                                      .Include(x => x.LeaveType)
                                      .FirstOrDefaultAsync(x => x.Id == Id);

            if (allocation == null)
            {
                return null;
            }

            var employee = await userManager.FindByIdAsync(allocation.EmployeeId);

            var employeeLeaveAllocations = mapper.Map<EditLeaveAllocationVM>(allocation);
            employeeLeaveAllocations.Employee = mapper.Map<EmployeeListVM>(employee);

            return employeeLeaveAllocations;

        }

        public async Task LeaveAllocation(int leaveTypeId)
        {
            var employees = await userManager.GetUsersInRoleAsync(Roles.User);
            var period = DateTime.Now.Year;
            var leaveType = await leaveTypeRepository.GetAsync(leaveTypeId);

            var listOfAllocation = new List<LeaveAllocation>();
            foreach (var employee in employees)
            {
                if (await AllocationExists(employee.Id, leaveTypeId, period))
                    continue;

                var allocation = new LeaveAllocation()
                {
                    EmployeeId = employee.Id,
                    Period = period,
                    LeaveTypeId = leaveTypeId,
                    NumberOfDays = leaveType.DefaultDays,
                    DateCreated = DateTime.Now,
                    DateModified = DateTime.Now,
                };

                listOfAllocation.Add(allocation);

            }
            await AddRangeAsync(listOfAllocation);
        }

        public async Task<bool> UpdateEmployeeAllocation(EditLeaveAllocationVM editLeaveAllocationVM)
        {
            var leaveAllocation = await GetAsync(editLeaveAllocationVM.Id);

            if (leaveAllocation == null)
            {
                return false;
            }

            leaveAllocation.Period = editLeaveAllocationVM.Period;
            leaveAllocation.NumberOfDays = editLeaveAllocationVM.NumberOfDays;

            await UpdateAsync(leaveAllocation);

            return true;
        }

        public async Task<LeaveAllocation?> GetEmployeeAllocation(string employeeId, int leaveTypeId)
        {
            return await dbContext.LeaveAllocations.FirstOrDefaultAsync(x => x.EmployeeId == employeeId && x.LeaveTypeId == leaveTypeId);
        }
    }
}
