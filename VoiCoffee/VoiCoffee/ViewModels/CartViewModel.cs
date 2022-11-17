using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using VoiCoffee.Model;
using VoiCoffee.Views;
using Xamarin.Forms;

namespace VoiCoffee.ViewModels
{
    public class CartViewModel : BaseViewModel
    {
        public ObservableCollection<UserCartItem> CartItems { get; set; }

        private int _TotalCost;
        public int TotalCost
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
        
        public Command PlaceOrdersCommand { get; set; }
        public CartViewModel()
        {
            CartItems = new ObservableCollection<UserCartItem>();
            LoadItems();
            PlaceOrdersCommand = new Command(async () => await PlaceOrderAsync());
        }

        private async Task PlaceOrderAsync()
        {
            //code to place order
            await Application.Current.MainPage.Navigation.PushModalAsync(new OrdersView());
        }

        private void LoadItems()
        {
            var cn = DependencyService.Get<ISQLite>().GetConnection();
            var items = cn.Table<CartItem>().ToList();
            CartItems.Clear();
            foreach( var item in items)
            {
                CartItems.Add(new UserCartItem()
                {
                    CartItemId= item.CartItemId,
                    ProductId = item.ProductId,
                    ProductName = item.ProductName,
                    Price = item.Price,
                    Quantity = item.Quantity,
                    Cost = item.Price * item.Quantity

                });
                TotalCost += (item.Price * item.Quantity);
                    
            }
        }
    }
}
