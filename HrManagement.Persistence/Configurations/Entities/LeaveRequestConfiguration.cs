﻿using Hr_Management;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HrManagement.Persistence.Configurations.Entities
{
    public class LeaveRequestConfiguration : IEntityTypeConfiguration<LeaveRequest>
    {
            public void Configure(EntityTypeBuilder<LeaveRequest> builder)
            {
                //builder.HasData(
                //    new LeaveRequest
                //    {

                //    },
                //    new LeaveRequest
                //    {

                //    }
                //    );

            }
        
    }
}
