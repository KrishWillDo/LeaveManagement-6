using AutoMapper;
using LeaveManagement_6.Contracts;
using LeaveManagement_6.Data;
using LeaveManagement_6.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.VisualStudio;

namespace LeaveManagement_6.Repository
{
    public class LeaveRequestRepository : GenericRepository<LeaveRequest>, ILeaveRequestRepository
    {
        private readonly ApplicationDbContext dbContext;
        private readonly IMapper mapper;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly UserManager<Employee> userManager;
        private readonly ILeaveAllocationRepository leaveAllocationRepository;

        public LeaveRequestRepository(ApplicationDbContext dbContext,
                                      IMapper mapper,
                                      IHttpContextAccessor httpContextAccessor,
                                      UserManager<Employee> userManager,
                                      ILeaveAllocationRepository leaveAllocationRepository) : base(dbContext)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
            this.httpContextAccessor = httpContextAccessor;
            this.userManager = userManager;
            this.leaveAllocationRepository = leaveAllocationRepository;
        }

        public async Task CancelLeaveRequest(int leaveRequestId)
        {
            var leaveRequests = await GetAsync(leaveRequestId);



            if (leaveRequests != null)
            {
                leaveRequests.Cancelled = true;
                var existingLeaves = await leaveAllocationRepository.GetEmployeeAllocation(leaveRequests.RequestingEmployeeId, leaveRequests.LeaveTypeId);
                if (existingLeaves != null)
                {
                    var numbeofDays = (int)(leaveRequests.EndDate - leaveRequests.StartDate).TotalDays;
                    existingLeaves.NumberOfDays += numbeofDays;

                    await leaveAllocationRepository.UpdateAsync(existingLeaves);
                }

                await UpdateAsync(leaveRequests);
            }
          
        }

        public async Task ChangeApprovalStatus(int leaveRequestId, bool approved)
        {
            var leaveRequests = await GetAsync(leaveRequestId);
            leaveRequests.Approved = approved;

            if (approved)
            {
                var existingLeaves = await leaveAllocationRepository.GetEmployeeAllocation(leaveRequests.RequestingEmployeeId, leaveRequests.LeaveTypeId);



                if (existingLeaves != null)
                {
                    var numbeofDays = (int)(leaveRequests.EndDate - leaveRequests.StartDate).TotalDays;
                    existingLeaves.NumberOfDays -= numbeofDays;

                    await leaveAllocationRepository.UpdateAsync(existingLeaves);
                }
            }

            await UpdateAsync(leaveRequests);

        }

        public async Task CreateLeaveRequest(LeaveRequestCreateVM request)
        {
            var user = await userManager.GetUserAsync(httpContextAccessor.HttpContext?.User);

            var leaveRequestModel = mapper.Map<LeaveRequest>(request);

            leaveRequestModel.DateCreated = DateTime.Now;
            leaveRequestModel.DateRequested = DateTime.Now;
            leaveRequestModel.RequestingEmployeeId = user.Id;

            await AddAsync(leaveRequestModel);
        }

        public async Task<AdminLeaveRequestViewVM> GetAdminLeaveRequestView()
        {
            var leaveRequest = await dbContext.LeaveRequests.Include(x => x.LeaveType).ToListAsync();

            var model = new AdminLeaveRequestViewVM
            {
                ApprovedRequests = leaveRequest.Count(x => x.Approved == true),
                TotalRequests = leaveRequest.Count,
                PendingRequests = leaveRequest.Count(x => x.Approved == null),
                RejectedRequests = leaveRequest.Count(x => x.Approved == false),
                LeaveRequests = mapper.Map<List<LeaveRequestVM>>(leaveRequest)
            };

            foreach (var request in model.LeaveRequests)
            {
                request.Employee = mapper.Map<EmployeeListVM>(await userManager.FindByIdAsync(request.RequestingEmployeeId));
            }

            return model;
        }

        public async Task<List<LeaveRequest>> GetAllAsync(string employeeId)
        {
            var requests = await dbContext.LeaveRequests.Where(x => x.RequestingEmployeeId == employeeId).ToListAsync();
            return requests;
        }

        public async Task<LeaveRequestVM> GetLeaveRequestAsync(int? id)
        {
            var leaveRequest = await dbContext.LeaveRequests.Include(x => x.LeaveType).FirstOrDefaultAsync(x => x.Id == id);

            if (leaveRequest == null)
            {
                return null;
            }
            var model = mapper.Map<LeaveRequestVM>(leaveRequest);
            model.Employee = mapper.Map<EmployeeListVM>(await userManager.FindByIdAsync(leaveRequest?.RequestingEmployeeId));

            return model;
        }

        public async Task<LeaveRequestViewVM> GetMyLeaveDetails()
        {
            var user = await userManager.GetUserAsync(httpContextAccessor.HttpContext?.User);

            var allocations = (await leaveAllocationRepository.GetEmployeeLeaveAllocations(user.Id)).LeaveAllocationVM;
            var requests = mapper.Map<List<LeaveRequestVM>>(await GetAllAsync(user.Id));

            var model = new LeaveRequestViewVM(allocations, requests);


            return model;

        }
    }
}
