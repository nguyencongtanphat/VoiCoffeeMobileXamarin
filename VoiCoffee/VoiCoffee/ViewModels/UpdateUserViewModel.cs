using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using VoiCoffee.Model;
using VoiCoffee.Services;
using VoiCoffee.Views;
using Xamarin.Essentials;
using Xamarin.Forms;
using static Xamarin.Essentials.Permissions;

namespace VoiCoffee.ViewModels
{
    public class UpdateUserViewModel : BaseViewModel
    {

        private string _Username;
        public string Username
        {
            set
            {
                this._Username = value;
                OnPropertyChanged();
            }
            get
            {
                return this._Username;
            }
        }

        private string _Fullname;
        public string Fullname
        {
            set
            {
                this._Fullname = value;
                OnPropertyChanged();
            }
            get
            {
                return this._Fullname;
            }
        }

        private string _Password;
        public string Password
        {
            set
            {
                this._Password = value;
                OnPropertyChanged();
            }
            get
            {
                return this._Password;
            }
        }

        public string _Address;
        public string Address
        {
            set
            {
                this._Address = value;
                OnPropertyChanged();
            }
            get
            {
                return this._Address;
            }
        }

        public string _Number;

        public string Number
        {
            set
            {
                this._Number = value;
                OnPropertyChanged();
            }
            get
            {
                return this._Number;
            }
        }

        public Command UpdateCommand { get; set; }
        public UpdateUserViewModel()
        {
            UpdateCommand = new Command(async () => {

                var userService = new UserService();

                string uname = Preferences.Get("Username", String.Empty);
                string fname = Preferences.Get("Fullname", String.Empty);
                string address = Preferences.Get("Address", String.Empty);
                string phone = Preferences.Get("Phonenumber", String.Empty);
                string password = Preferences.Get("Password", String.Empty);

                User newUser = new User
                {
                    Username = (_Username == null) ? uname.ToString() : Username,
                    Fullname = (_Fullname == "") ? fname.ToString() : Fullname,
                    Address = (_Address == "") ? address.ToString() : Address,
                    Phonenumber = (_Number == "") ? phone.ToString() : Number,
                    Password = (_Password == "") ? password.ToString() : Password,
                };


                userService.updateUser(newUser);

                await Application.Current.MainPage.DisplayAlert("Thông báo", "Bạn đã chỉnh sửa thông tin thành công", "OK");
                
                await Application.Current.MainPage.Navigation.PopModalAsync();
            });
        }

    }
}