using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Firebase.Database;
using VoiCoffee.Model;
using Xamarin.Essentials;

namespace VoiCoffee.Services
{
    public class HistoryService
    {
        FirebaseClient client;

        private string _UserName;
        

        public HistoryService()
        {
            client = new FirebaseClient("https://coffeorderingapp-cef55-default-rtdb.asia-southeast1.firebasedatabase.app/");
            var uname = Preferences.Get("Username", String.Empty);
            if (String.IsNullOrEmpty(uname))
                _UserName = "Guest";
            else
                _UserName = uname;
        }



        public async Task<List<Order>> GetOrderAsync()
        {
            var orders = (await client.Child("Orders")
                .OnceAsync<Order>())
                .Select(f => new Order
                {
                    //CategoryID = f.Object.CategoryID,
                    OrderId = f.Object.OrderId,
                    TotalCost = f.Object.TotalCost,
                    Username = f.Object.Username,
                }).ToList();
            return orders;
        }

        public async Task<ObservableCollection<Order>> GetOrderByUser()
        {
            var orders = new ObservableCollection<Order>();
            var items = (await GetOrderAsync()).Where(p => p.Username == _UserName).ToList();
            
            foreach (var item in items)
            {
                orders.Add(item);
            }
            return orders;
        }

        public async Task<List<OrderDetails>> GetOrderDetailAsync(string id)
        {
            var ordersDetail = (await client.Child("OrderDetails")
                .OnceAsync<OrderDetails>())
                .Select(f => new OrderDetails
                {
                    //CategoryID = f.Object.CategoryID,
                    OrderDetailId = f.Object.OrderDetailId,
                    OrderId = f.Object.OrderId,
                    ProductId = f.Object.ProductId,
                    ProductName = f.Object.ProductName,
                    Quantity = f.Object.Quantity,
                    Price = f.Object.Price,
                    Cost = f.Object.Quantity * f.Object.Price
                }).ToList().Where(p=> p.OrderId == id).ToList();
            return ordersDetail;
        }
    }
}
