using AutoMapper;
using Hr_Management.Application.DTOs.Allocation;
using Hr_Management.Application.DTOs.Request;
using Hr_Management.Application.DTOs.Type;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hr_Management.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<LeaveRequest, LeaveRequestDto>().ReverseMap();
            CreateMap<LeaveRequest, LeaveRequestListDto>().ReverseMap();
            CreateMap<LeaveType, LeaveTypeDto>().ReverseMap();
            CreateMap<LeaveAllocation, LeaveAllocationDto>().ReverseMap();
        }
    }
}
