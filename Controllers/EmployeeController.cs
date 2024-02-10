using ASPNET_Core_ViewModel.Business;
using ASPNET_Core_ViewModel.Models;
using ASPNET_Core_ViewModel.Models.ViewModels;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace ASPNET_Core_ViewModel.Controllers
{
    public class EmployeeController : Controller
    {
        public IMapper Mapper { get; }

        public EmployeeController(IMapper mapper) 
        {
            Mapper = mapper;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(EmployeeCreateVM employeeCreateVM)
        {
            #region Manually convert ViewModel to Entity Model:

            /* 
            Employee e = new Employee()
            {
                Name = employeeCreateVM.Name,
                Surname = employeeCreateVM.Surname,
            };
             */
            #endregion

            #region Convert with Implicit operator:
            /*
            Employee employee = employeeCreateVM;

            EmployeeCreateVM vm = employee;
            */
            #endregion

            #region Convert with Explicit operator:
            /*
            Employee employee = (Employee)employeeCreateVM;

            EmployeeCreateVM vm = (EmployeeCreateVM)employee;
            */
            #endregion

            #region Convert with Reflection:

            // Employee e = TypeConversion.Conversion<EmployeeCreateVM, Employee>(employeeCreateVM);

            #endregion

            #region Convert with AutoMapper:

            Employee e = Mapper.Map<Employee>(employeeCreateVM);
            EmployeeCreateVM e2 = Mapper.Map<EmployeeCreateVM>(e);
           
            #endregion


            return View();
        }



        public IActionResult List()
        {

            #region NOT BEST PRACTICE 
            /* 
              List<Employee> employees = new List<Employee>
              {
                  new Employee {Name = "A", Surname = "B"},
                  new Employee {Name = "A", Surname = "B"},
                  new Employee {Name = "A", Surname = "B"},
              };    
            */
            #endregion

            #region ViewModel

            List<EmployeeListVM> employees = new List<Employee>
            {
                new Employee {Name = "A", Surname = "B"},
                new Employee {Name = "A", Surname = "B"},
                new Employee {Name = "A", Surname = "B"},
            }.Select(e => new EmployeeListVM
            {
                Name = e.Name,
                Surname = e.Surname,
                Position = e.Position,
            }).ToList();
              
            return View(employees);


            /* Data obtained from the Database is not directly transmitted 
               to the relevant views or clients.
               It is sent after being converted to certain formats in ViewModel.

               Any data presented to the user should not be of the entity type directly in the database.
               In such cases ViewModel should be used. */

            #endregion
            
        }

        public IActionResult Get() 
        {
            // var obj = (new Employee(), new Product(), new Customer());

            return View();
        }

    }

       
}

