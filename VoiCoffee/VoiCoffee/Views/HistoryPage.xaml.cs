using System;
using System.Collections.Generic;
using VoiCoffee.Model;
using Xamarin.Forms;

namespace VoiCoffee.Views
{
    public partial class HistoryPage : ContentPage
    {
        public HistoryPage()
        {
            InitializeComponent();
            InitializeHistory();
        }
        void InitializeHistory()
        {
            List<Order> orderList = new List<Order>();
            //orderList.Add(new Order { OrderId = "3781ad5fa514", TotalCost = 185000, Username = "trunng" });
            //orderList.Add(new Order { OrderId = "b781ad5fa514", TotalCost = 205000, Username = "trunng" });
            //orderList.Add(new Order { OrderId = "kv81ad5fa514", TotalCost = 75000, Username = "trunng" });
            //orderList.Add(new Order { OrderId = "0781ad5fa514", TotalCost = 55000, Username = "trunng" });
            //LstOrder.ItemsSource = orderList;
        }

        async void ImageButton_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        private async void abc_ItemTapped(System.Object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
            if (abc.SelectedItem != null)
            {
                Order order = (Order)abc.SelectedItem;
                await Navigation.PushModalAsync(new OrderDetailView(order));
            }

        }


        //private async void LstOrder_ItemTapped(System.Object sender, Xamarin.Forms.ItemTappedEventArgs e)
        //{
        //    if (LstOrder.SelectedItem != null)
        //    {
        //        Order order = (Order)LstOrder.SelectedItem;
        //        await Navigation.PushModalAsync(new OrderDetailView());
        //    }
        //}


    }
}
