using AutoMapper;
using LeaveManagementWeb.Data;
using LeaveManagementWeb.Models;

namespace LeaveManagementWeb.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<LeaveType, LeaveTypeVM>().ReverseMap();      
            CreateMap<Employee, EmployeeAllocationVM>().ReverseMap();      
            CreateMap<Employee, EmployeeListVM>().ReverseMap();      
            CreateMap<LeaveAllocation, LeaveAllocationVM>().ReverseMap();      
            CreateMap<LeaveAllocation, LeaveAllocationEditVM>().ReverseMap();      
            CreateMap<LeaveRequest, LeaveRequestCreateVM>().ReverseMap();      
            CreateMap<LeaveRequest, LeaveRequestVM>().ReverseMap();      
        }
    }
}
