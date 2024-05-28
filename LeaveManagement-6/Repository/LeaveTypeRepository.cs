using LeaveManagement_6.Contracts;
using LeaveManagement_6.Data;

namespace LeaveManagement_6.Repository
{
    public class LeaveTypeRepository : GenericRepository<LeaveType>, ILeaveTypeRepository
    {
        public LeaveTypeRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
