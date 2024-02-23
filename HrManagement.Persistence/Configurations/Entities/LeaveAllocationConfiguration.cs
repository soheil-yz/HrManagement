using Hr_Management;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HrManagement.Persistence.Configurations.Entities
{
    public class LeaveAllocationConfiguration //: IEntityTypeConfiguration<LeaveRequest>
    {
        public void Configure(EntityTypeBuilder<LeaveAllocation> builder)
        {
            //builder.HasData(
            //    new LeaveAllocation
            //    {

            //    },
            //    new LeaveAllocation
            //    {

            //    }
            //    );

        }
    }
}
