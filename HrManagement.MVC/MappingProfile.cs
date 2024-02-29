using AutoMapper;
using Hr_Management.Application.DTOs.Type;
using HrManagement.MVC.Models;

namespace HrManagement.MVC
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateLeaveTypeDto,CreateLeaveTypeViewModel>().ReverseMap();
            CreateMap<LeaveTypeDto, LeaveTypeViewModel>().ReverseMap();
        }
    }
}
