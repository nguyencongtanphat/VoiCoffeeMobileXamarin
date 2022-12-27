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
    public class HistoryViewModel : BaseViewModel
    {
        private string _UserName;
        public ObservableCollection<Order> ordersList { get; set; }

        public string UserName
        {
            set
            {
                _UserName = value;
                OnPropertyChanged();
            }
            get
            {
                return _UserName;
            }
        }

        public HistoryViewModel()
        {
            var uname = Preferences.Get("Username", String.Empty);
            if (String.IsNullOrEmpty(uname))
                UserName = "Guest";
            else
                UserName = uname;
            ordersList = new ObservableCollection<Order>();
            GetOrders();

        }

        private async void GetOrders()
        {
            var data = await new HistoryService().GetOrderByUser();
            
            foreach (var item in data)
            {
                ordersList.Add(item);
            }
        }
    }

}
