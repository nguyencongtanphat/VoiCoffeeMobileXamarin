using System;
using System.Threading.Tasks;
using Firebase.Database;
using Firebase.Database.Query;
using VoiCoffee.Model;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace VoiCoffee.Services
{
    public class OrderService
    {
        FirebaseClient client;
        public OrderService()
        {
            client = new FirebaseClient("https://coffeorderingapp-cef55-default-rtdb.asia-southeast1.firebasedatabase.app/");
        }

        public async Task<string> PlaceOrderAsync()
        {
            var cn = DependencyService.Get<ISQLite>().GetConnection();
            var data = cn.Table<CartItem>().ToList();

            var orderId = Guid.NewGuid().ToString();
            var uname = Preferences.Get("Username","Guest");

            decimal totalCost = 0;

            foreach (var item in data)
            {
                OrderDetails od = new OrderDetails()
                {
                    OrderId = orderId,
                    OrderDetailId = Guid.NewGuid().ToString(),
                    ProductId = item.ProductId,
                    ProductName = item.ProductName,
                    Price = item.Price,
                    Quantity = item.Quantify
                };
                totalCost += item.Price * item.Quantify;
                await client.Child("OrderDetails").PostAsync(od);
            }

            await client.Child("Orders").PostAsync(new Order() { OrderId = orderId, Username = uname, TotalCost = totalCost });
            return orderId;
        }
    }
}
