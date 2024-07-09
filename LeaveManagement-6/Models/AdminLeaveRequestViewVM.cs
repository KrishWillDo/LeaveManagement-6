using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;

namespace LeaveManagement_6.Models
{
    public class AdminLeaveRequestViewVM
    {
        [DisplayName("Total number of requests")]
        public int TotalRequests { get; set; }
        [DisplayName("Approved Requests")]
        public int ApprovedRequests { get; set; }
        [DisplayName("Rejected Requests")]
        public int RejectedRequests { get; set; }
        [DisplayName("Pending Requests")]
        public int PendingRequests { get; set; }

        public List<LeaveRequestVM>? LeaveRequests { get; set; }
    }
}
