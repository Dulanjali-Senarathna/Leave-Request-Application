using Leave_Request_Application.Data;

namespace Leave_Request_Application.Contracts
{
    public interface ILeaveAllocationRepository : IGenericRepository<LeaveAllocation>
    {
       Task LeaveAllocation (int leaveTypeId);
        Task<bool> AllocationExists (string employeeId, int leaveTypeId, int period);
    }
}
