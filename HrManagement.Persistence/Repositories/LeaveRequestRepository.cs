using Hr_Management.Application.Persistence.Contracts;
using Hr_Management;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HrManagement.Persistence.Repositories
{
    public class LeaveRequestRepository : GenericRepository<LeaveRequest>, ILeaveRequestRepository
    {
        private readonly LeaveManagementDbContext _context;
        public LeaveRequestRepository(LeaveManagementDbContext context) : base(context)
        {
            _context = context;
        }

        public Task ChangeApprovalStatus(LeaveRequest leaveRequest, bool? approvalStatus)
        {
            leaveRequest.Apprived = approvalStatus;
            _context.Entry(leaveRequest).State = EntityState.Modified;
            return _context.SaveChangesAsync();
        }

        public async Task<List<LeaveRequest>> GetLeaveRequestsWithDetails()
        {
            var leaveRequest = await _context.leaveRequests
                .Include(t=>t.LeaveType)
                .ToListAsync();
            return leaveRequest;
        }

        public async Task<LeaveRequest> GetLeaveRequestWithDetails(int id)
        {
            var leaveRequest = await _context.leaveRequests
            .Include(t => t.LeaveType)
             .FirstOrDefaultAsync(t=>t.Id == id);
            return leaveRequest;
        }
    }
}
