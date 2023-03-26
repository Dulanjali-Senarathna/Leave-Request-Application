using AutoMapper;
using Leave_Request_Application.Data;
using Leave_Request_Application.Models;

namespace Leave_Request_Application.Configurations
{
    public class MapperConfig:Profile
    {
        public MapperConfig()
        {
            CreateMap<LeaveType, LeaveTypeVM>().ReverseMap();
        }
    }
}
