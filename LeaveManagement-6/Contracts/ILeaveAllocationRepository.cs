using LeaveManagement_6.Data;
using LeaveManagement_6.Models;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LeaveManagement_6.Contracts
{
    public interface ILeaveAllocationRepository : IGenericRepository<LeaveAllocation>
    {
        Task LeaveAllocation(int leaveTypeId);
        Task<bool> AllocationExists(string employeeId, int leaveTypeId, int period);
        Task<EmployeeLeaveAllocationVM> GetEmployeeLeaveAllocations(string employeeId);
        Task<EditLeaveAllocationVM> GetEmployeeLeaveAllocation(int Id);

        Task<bool> UpdateEmployeeAllocation(EditLeaveAllocationVM editLeaveAllocationVM);
    }
}
