using Hr_Management;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HrManagement.Persistence.Configurations.Entities
{
    public class LeaveTypeConfiguration : IEntityTypeConfiguration<LeaveType>
    {
        public void Configure(EntityTypeBuilder<LeaveType> builder)
        {
            builder.HasData(
                new LeaveType { 
                Id = 1,
                DefaultDay = 10,
                Name = "Vocations",
                
                },               
                new LeaveType { 
                Id = 2,
                DefaultDay = 12,
                Name = "Sick",
                
                }
                );

        }
    }
}
