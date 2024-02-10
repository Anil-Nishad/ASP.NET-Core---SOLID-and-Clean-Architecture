using AutoMapper;
using HR.LeaveManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.MappingProfiles
{
    public class LeaveRequestProfile : Profile
    {
        public LeaveRequestProfile()
        {
            //CreateMap<LeaveRequestListDto, LeaveRequest>().ReverseMap();
            //CreateMap<LeaveRequestDetailsDto, LeaveRequest>().ReverseMap();
            //CreateMap<LeaveRequest, LeaveRequestDetailsDto>();
            //CreateMap<CreateLeaveRequestCommand, LeaveRequest>();
            //CreateMap<UpdateLeaveRequestCommand, LeaveRequest>();
        }
    }
}
