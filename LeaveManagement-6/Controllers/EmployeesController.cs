using AutoMapper;
using LeaveManagement_6.Constants;
using LeaveManagement_6.Contracts;
using LeaveManagement_6.Data;
using LeaveManagement_6.Models;
using LeaveManagement_6.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace LeaveManagement_6.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly UserManager<Employee> userManager;
        private readonly IMapper mapper;
        private readonly ILeaveAllocationRepository leaveAllocationRepository;

        public ILeaveTypeRepository LeaveTypeRepository { get; }

        // GET: EmployeesController



        public EmployeesController(UserManager<Employee> userManager, IMapper mapper,
                                    ILeaveAllocationRepository leaveAllocationRepository
                                    , ILeaveTypeRepository leaveTypeRepository)
        {
            this.userManager = userManager;
            this.mapper = mapper;
            this.leaveAllocationRepository = leaveAllocationRepository;
            LeaveTypeRepository = leaveTypeRepository;
        }
        public async Task<ActionResult> Index()
        {
            var employee = await userManager.GetUsersInRoleAsync(Roles.User);
            var viewModel = mapper.Map<List<EmployeeListVM>>(employee);

            return View(viewModel);
        }

        // GET: EmployeesController/ViewAllocations/employeeId
        public async Task<ActionResult> ViewAllocations(string employeeId)
        {
            var model = await leaveAllocationRepository.GetEmployeeLeaveAllocations(employeeId);
            return View(model);
        }

        // GET: EmployeesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeesController/EditAllocations/5
        public async Task<IActionResult> EditAllocations(int id)
        {
            var model = await leaveAllocationRepository.GetEmployeeLeaveAllocation(id);
            if (model == null)
            {
                return NotFound();
            }

            return View(model);
        }

        // POST: EmployeesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditAllocations(EditLeaveAllocationVM model)
        {
            try
            {
                var update = await leaveAllocationRepository.UpdateEmployeeAllocation(model);
                if (update)
                {
                    return RedirectToAction(nameof(ViewAllocations), new { employeeId = model.EmployeeId });
                }
            }

            catch (Exception ex)
            {

            }

            model.Employee = mapper.Map<EmployeeListVM>(userManager.FindByIdAsync(model.EmployeeId));
            model.LeaveType = mapper.Map<LeaveTypeVM>(LeaveTypeRepository.GetAsync(model.LeaveTypeId));

            return View(model);
        }

        // GET: EmployeesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmployeesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
