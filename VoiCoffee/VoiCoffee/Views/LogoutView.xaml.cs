using System;
using System.Collections.Generic;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace VoiCoffee.Views
{
    public partial class LogoutView : ContentPage
    {
        public LogoutView()
        {
            InitializeComponent();
            LabelName.Text = "Xác nhận Đăng xuất khỏi " + Preferences.Get("Username", "Guest") + ",";
        }

        async void ImageButton_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}
