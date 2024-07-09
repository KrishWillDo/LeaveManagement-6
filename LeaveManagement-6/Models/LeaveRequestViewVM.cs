namespace LeaveManagement_6.Models
{
    public class LeaveRequestViewVM
    {
        public List<LeaveAllocationVM>? LeaveAllocations { get; set; }
        public List<LeaveRequestVM>? LeaveRequests { get; set; }

        public LeaveRequestViewVM(List<LeaveAllocationVM>? LeaveAllocations, List<LeaveRequestVM>? LeaveRequests)
        {
            this.LeaveAllocations = LeaveAllocations;
            this.LeaveRequests = LeaveRequests;
        }
    }
}
