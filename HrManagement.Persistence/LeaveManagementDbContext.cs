using Hr_Management;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HrManagement.Persistence
{
    public class LeaveManagementDbContext : DbContext
    {
        public LeaveManagementDbContext(DbContextOptions<LeaveManagementDbContext> options) : base(options)
        {
            
        }
        public DbSet<LeaveRequest> leaveRequests {  get; set; }
        public DbSet<LeaveAllocation> leaveAllocations {  get; set; }
        public DbSet<LeaveType> leaveTypes {  get; set; }
        
    }
}
