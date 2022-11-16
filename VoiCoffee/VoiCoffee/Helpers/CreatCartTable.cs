using System;
using VoiCoffee.Model;
using Xamarin.Forms;

namespace VoiCoffee.Helpers
{
    public class CreatCartTable
    {
        public bool CreateTable()
        {
            try
            {
                var cn = DependencyService.Get<ISQLite>().GetConnection();
                cn.CreateTable<CartItem>();
                cn.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
