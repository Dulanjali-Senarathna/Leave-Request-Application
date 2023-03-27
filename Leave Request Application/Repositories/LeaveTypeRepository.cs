using Leave_Request_Application.Contracts;
using Leave_Request_Application.Data;

namespace Leave_Request_Application.Repositories
{
    public class LeaveTypeRepository : GenericRepository<LeaveType>, ILeaveTypeRepository
    {
        public LeaveTypeRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
