using AutoMapper;
using LeaveManagement.Web.Data;
using LeaveManagement.Web.Models;

namespace LeaveManagement.Web.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            // define route to mak conversion from one to another and back

            CreateMap<LeaveType, LeaveTypeVM>().ReverseMap();
        }
    }
}
