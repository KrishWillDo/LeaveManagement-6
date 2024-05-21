namespace LeaveManagement_6.Data
{
    // If we make a class as partial we cant instantiate it.
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}
