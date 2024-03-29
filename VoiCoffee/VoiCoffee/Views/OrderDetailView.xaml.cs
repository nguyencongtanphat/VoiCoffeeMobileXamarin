﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using VoiCoffee.Model;
using VoiCoffee.Services;
using VoiCoffee.ViewModels;

using Xamarin.Forms;

namespace VoiCoffee.Views
{
    public partial class OrderDetailView : ContentPage
    {
        public ObservableCollection<OrderDetails> ordersList { get; set; }

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

        public OrderDetailView(Order order)
        {
            InitializeComponent();

            ordersList = new ObservableCollection<OrderDetails>();

            GetABC(order.OrderId);

            //this.ViewModel = new OrderDetailsViewModel();
            InitializeOrderDetail();
            TotalCost = 0;
            Idd.Text = order.OrderId;
            totalCost.Text = "Tổng tiền: " + order.TotalCost.ToString() + "đ";
        }

        //public OrderDetailsViewModel ViewModel
        //{
        //    get { return this.DataContext as OrderDetailsViewModel; }
        //    set { this.DataContext = value; }
        //}

        void InitializeOrderDetail()
        {
            //List<OrderDetails> orderList = new List<OrderDetails>();
            //orderList.Add(new OrderDetails { OrderDetailId = "1", Price = 45000, OrderId = "abcd", ProductId = 1, ProductName = "Trà Đào Cam - Sả", Quantity = 2 });
            //orderList.Add(new OrderDetails { OrderDetailId = "2", Price = 55000, OrderId = "abcd", ProductId = 2, ProductName = "Matcha Đá Xay", Quantity = 3 });
            //orderList.Add(new OrderDetails { OrderDetailId = "3", Price = 45000, OrderId = "abcd", ProductId = 5, ProductName = "Trà Oolong Sữa", Quantity = 1 });
            //List<OrderDetailsWithCost> orderListCost = new List<OrderDetailsWithCost>();
            //foreach (var item in ordersList)
            //{
            //    orderListCost.Add(new OrderDetailsWithCost()
            //    {
            //        OrderDetailId = item.OrderDetailId,
            //        ProductId = item.ProductId,
            //        OrderId = item.OrderId,
            //        ProductName = item.ProductName,
            //        Price = item.Price,
            //        Quantity = item.Quantity,
            //        Cost = item.Price * item.Quantity
            //    });
            //}
            ListOrderDetails.ItemsSource = ordersList;
        }
        async void ImageButton_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        private async void GetABC(string id)
        {
            var data = await new HistoryService().GetOrderDetailAsync(id);

            foreach (var item in data)
            {
                ordersList.Add(item);
            }
        }
    }
}
