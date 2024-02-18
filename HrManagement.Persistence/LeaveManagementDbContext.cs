using Hr_Management;
using Hr_Management.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HrManagement.Persistence
{
    public class LeaveManagementDbContext : DbContext
    {
        public LeaveManagementDbContext(DbContextOptions<LeaveManagementDbContext> options) : base(options)
        {

        }
        public DbSet<LeaveRequest> leaveRequests { get; set; }
        public DbSet<LeaveAllocation> leaveAllocations { get; set; }
        public DbSet<LeaveType> leaveTypes { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(LeaveManagementDbContext).Assembly);
        }

        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {
            foreach (var entry in ChangeTracker.Entries<BaseDomainEntity>())
            {
                entry.Entity.LastModifiedDate = DateTime.Now;
                if (entry.State == EntityState.Added)
                      entry.Entity.DateCreated = DateTime.Now;
            }
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);              
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries<BaseDomainEntity>())
            {
                entry.Entity.LastModifiedDate = DateTime.Now;
                if (entry.State == EntityState.Added)
                    entry.Entity.DateCreated = DateTime.Now;
            }
            return base.SaveChanges();
        }
    }
}
