using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using VoiCoffee.Model;
using VoiCoffee.Services;
using VoiCoffee.Views;
using Xamarin.Forms;

namespace VoiCoffee.ViewModels
{
    public class CartViewModel : BaseViewModel
    {
        public ObservableCollection<UserCartItem> CartItems { get; set; }

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
            var id = await new OrderService().PlaceOrderAsync() as string;
            RemoveItemsFromCart();

            await Application.Current.MainPage.Navigation.PushModalAsync(new OrdersView(id));
        }

        private void RemoveItemsFromCart()
        {
            var cis = new CartItemService();
            cis.RemoveItemsFromCart();
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
                    Quantity = item.Quantify,
                    Cost = item.Price * item.Quantify

                });
                TotalCost += (item.Price * item.Quantify);
                    
            }
        }
    }
}
