using Firebase.Database;
using Firebase.Database.Query;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VoiCoffee.Model;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VoiCoffee.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UserInfoView : ContentPage
    {
        public string uname;
        public string fname;

        FirebaseClient client;
        public UserInfoView()
        {
            InitializeComponent();
            client = new FirebaseClient("https://coffeorderingapp-cef55-default-rtdb.asia-southeast1.firebasedatabase.app/");
            uname1.Text = Preferences.Get("Username", String.Empty);
            abc.Text = Preferences.Get("Fullname", String.Empty);
            address1.Text = Preferences.Get("Address", String.Empty);
            phone1.Text = Preferences.Get("Phonenumber", String.Empty);
        }

        private async void update_btn_Clicked(object sender, EventArgs e)
        {
            User user = new User
            {
                Username = "ABC",
                Fullname = "ABCD",
                Phonenumber = "2904920490",
                Password = "123445",
                Address = "FSAKFKJSDAK"


            };
            //await client.Child("Users").Child("-NKhnV_PzQnMPzgde1QC").PutAsync(JsonConvert.SerializeObject(user));
            DisplayAlert("Thông tin user", "update thành công", "close");
        }

        private async void logout_btn_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new LogoutView());
        }
    }
}