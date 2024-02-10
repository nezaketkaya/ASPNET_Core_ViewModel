namespace ASPNET_Core_ViewModel.Models.ViewModels
{
    public class EmployeeCreateVM
    {

        //ViewModel'da sadece view'e taşınacak olan verilerin property'leri temsil edilir.
        //Bir Model'in View'deki etkileşimine uygun parçasını temmsil etme
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
