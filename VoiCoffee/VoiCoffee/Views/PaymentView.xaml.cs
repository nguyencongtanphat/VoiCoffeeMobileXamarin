using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VoiCoffee.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VoiCoffee.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaymentView : ContentPage
    {
        List<Banker> bankList;
        string idd;
        public PaymentView(string id)
        {
            InitializeComponent();
            bankList = new List<Banker>();

            bankList.Add(new Banker
            {
                bankName = "Agribank",
                bankImage = "https://firebasestorage.googleapis.com/v0/b/coffeorderingapp-cef55.appspot.com/o/argibank.png?alt=media&token=9adc721d-5c69-42f3-b2c9-d92b4aee0d56",
            });

            bankList.Add(new Banker
            {
                bankName = "Vietcombank",
                bankImage = "https://firebasestorage.googleapis.com/v0/b/coffeorderingapp-cef55.appspot.com/o/vietcombank.png?alt=media&token=23e7b14d-2f21-4df0-9ed1-b16437c1f771"
            });

            bankList.Add(new Banker
            {
                bankName = "OCB",
                bankImage = "https://firebasestorage.googleapis.com/v0/b/coffeorderingapp-cef55.appspot.com/o/ocbbank.png?alt=media&token=a18b7378-d128-4cf3-89ec-d847cc53c507"
            });

            bankList.Add(new Banker
            {
                bankName = "BIDV",
                bankImage = "https://firebasestorage.googleapis.com/v0/b/coffeorderingapp-cef55.appspot.com/o/bidvbank.png?alt=media&token=4829153c-0d1b-44a2-9e85-84283f7d170b"
            });

            bankCollectionView.ItemsSource = bankList;
            idd = id;
        }

        private async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new OrdersView(idd));
        }

        async void ImageButton_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}