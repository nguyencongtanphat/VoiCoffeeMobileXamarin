using System;
using System.Collections.Generic;
using VoiCoffee.Model;
using Xamarin.Forms;

namespace VoiCoffee.Views
{
    public partial class OrderDetailView : ContentPage
    {
        private decimal _TotalCost;
        public decimal TotalCost
        {
            get
            {
                return _TotalCost;
            }
            set
            {
                _TotalCost = value;
                OnPropertyChanged();
            }
        }

        public OrderDetailView()
        {
            InitializeComponent();
            InitializeOrderDetail();
            TotalCost = 0;
            
        }
        void InitializeOrderDetail()
        {
            List<OrderDetails> orderList = new List<OrderDetails>();
            orderList.Add(new OrderDetails { OrderDetailId = "1", Price = 45000, OrderId = "abcd", ProductId = 1, ProductName = "Trà Đào Cam - Sả", Quantity = 2 });
            orderList.Add(new OrderDetails { OrderDetailId = "2", Price = 55000, OrderId = "abcd", ProductId = 2, ProductName = "Matcha Đá Xay", Quantity = 3 });
            orderList.Add(new OrderDetails { OrderDetailId = "3", Price = 45000, OrderId = "abcd", ProductId = 5, ProductName = "Trà Oolong Sữa", Quantity = 1 });
            List<OrderDetailsWithCost> orderListCost = new List<OrderDetailsWithCost>();
            foreach (var item in orderList)
            {
                orderListCost.Add(new OrderDetailsWithCost()
                {
                    OrderDetailId = item.OrderDetailId,
                    ProductId = item.ProductId,
                    OrderId = item.OrderId,
                    ProductName = item.ProductName,
                    Price = item.Price,
                    Quantity = item.Quantity,
                    Cost = item.Price * item.Quantity
                });
                TotalCost += (item.Price * item.Quantity);
            }
            ListOrderDetails.ItemsSource = orderListCost;
            totalCost.Text = "Tổng tiền: "+ TotalCost.ToString()+"đ";
        }
        async void ImageButton_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}
