using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VoiCoffee.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrdersView : ContentPage
    {
        public OrdersView(string id)
        {
            InitializeComponent();
            LabelName.Text = "Đặt hàng thành công!";
            LabelOrderID.Text = id;
            Hoten.Text =  "Họ tên:             " +  Preferences.Get("Fullname", "Guest");
            SDT.Text =    "Số điện thoại:  " + Preferences.Get("Phonenumber", "Guest");
            Diachi.Text = "Địa chỉ:             " + Preferences.Get("Address", "Guest");
        }

        async void ImageButton_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new ProductsView());
        }
    }
}