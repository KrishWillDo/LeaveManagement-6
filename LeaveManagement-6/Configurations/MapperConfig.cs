using AutoMapper;
using LeaveManagement_6.Data;
using LeaveManagement_6.Models;

namespace LeaveManagement_6.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<LeaveType, LeaveTypeVM>().ReverseMap();
        }
    }
}
