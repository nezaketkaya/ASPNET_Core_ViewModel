using ASPNET_Core_ViewModel.Models.ViewModels;

namespace ASPNET_Core_ViewModel.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Position { get; set; }
        public bool MaritalStatus { get; set; }


        #region Convert ViewModel to Entity Model with implicit operator:
        /*
        public static implicit operator EmployeeCreateVM(Employee model)
        {
            return new EmployeeCreateVM
            {
                Name = model.Name,
                Surname = model.Surname,
            };
        }

        public static implicit operator Employee(EmployeeCreateVM model)
        {
            return new Employee
            {
                Name = model.Name,
                Surname = model.Surname,
            };

        } */

        #endregion

        #region Convert ViewModel to Entity Model with explicit operator:


        public static explicit operator EmployeeCreateVM(Employee model)
        {
            return new EmployeeCreateVM
            {
                Name = model.Name,
                Surname = model.Surname,
            };
        }

        public static explicit operator Employee(EmployeeCreateVM model)
        {
            return new Employee
            {
                Name = model.Name,
                Surname = model.Surname,
            };

        }
        #endregion

        #region Convert with Reflection:
        #endregion
    }
}
