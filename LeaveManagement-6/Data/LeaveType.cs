namespace LeaveManagement_6.Data
{
    public class LeaveType : BaseEntity
    {
        /// <summary>
        /// We can add LeaveTypeId/Id which will consider as primary key
        /// </summary>
        public string Name { get; set; }
        public int DefaultDays { get; set; }
    }
}
