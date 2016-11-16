using System.Windows.Forms;

namespace MealRestaurant
{
    /// <summary>
    /// 因Form可以是StartUp,Fronted或是Backened，故傳回值採用泛型
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public static class SingletonForm<T> where T:Form,new()
    {
        private static T customerForm = null;
       
        public static T FormSingleton()
        {
                if (customerForm == null || customerForm.IsDisposed)
                {
                    customerForm = new T();
                    customerForm.Show();
                }
                return customerForm;
        }
    }
}
