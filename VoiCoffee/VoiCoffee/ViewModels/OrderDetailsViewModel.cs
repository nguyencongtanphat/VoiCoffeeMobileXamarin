using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using VoiCoffee.Model;
using VoiCoffee.Services;
using VoiCoffee.Views;
using Xamarin.Essentials;
using Xamarin.Forms;
namespace VoiCoffee.ViewModels
{
    public class OrderDetailsViewModel : BaseViewModel
    {
        public ObservableCollection<OrderDetails> ordersList { get; set; }

        public OrderDetailsViewModel()
        {
            ordersList = new ObservableCollection<OrderDetails>();

            GetABC();
        }

        private string _id;
        public string id
        {
            set { 
                _id = value;
                OnPropertyChanged();
            }

            get { return _id; }
        }

        private async void GetABC()
        {
            var data = await new HistoryService().GetOrderDetailAsync(id);

            foreach (var item in data)
            {
                ordersList.Add(item);
            }
        }
    }
}