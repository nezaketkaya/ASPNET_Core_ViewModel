
namespace ASPNET_Core_ViewModel.Business
{
    public class TypeConversion
    { /*
        public static TResult Conversion<T, TResult>(T model) where TResult : class, new() 
        {
            TResult result = new TResult();
            typeof(T).GetProperties().ToList().ForEach(p =>  
            {
                var property = typeof(TResult).GetProperty(p.Name);
                property.SetValue(result, p.GetValue(model));
            });

            return result;
        }

        internal static T2 Conversion<T1, T2>()
        {
            throw new NotImplementedException();
        }*/
    }
}
