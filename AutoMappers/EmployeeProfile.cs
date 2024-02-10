using ASPNET_Core_ViewModel.Models;
using ASPNET_Core_ViewModel.Models.ViewModels;
using AutoMapper;

namespace ASPNET_Core_ViewModel.AutoMappers
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile() 
        {
            CreateMap<Employee, EmployeeCreateVM>();
            CreateMap<EmployeeCreateVM, Employee>();
        }
    }
}
