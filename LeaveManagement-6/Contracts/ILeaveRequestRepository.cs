using LeaveManagement_6.Data;
using LeaveManagement_6.Models;
using LeaveManagement_6.Repository;

namespace LeaveManagement_6.Contracts
{
    public interface ILeaveRequestRepository : IGenericRepository<LeaveRequest>
    {
        Task CreateLeaveRequest(LeaveRequestCreateVM request);
        Task<LeaveRequestViewVM> GetMyLeaveDetails();
        Task<List<LeaveRequest>> GetAllAsync(string employeeId);

        Task<AdminLeaveRequestViewVM> GetAdminLeaveRequestView();
        Task ChangeApprovalStatus(int leaveRequestId, bool approved);

        Task<LeaveRequestVM> GetLeaveRequestAsync(int? id);

        Task CancelLeaveRequest(int leaveRequestId);

    }
}
