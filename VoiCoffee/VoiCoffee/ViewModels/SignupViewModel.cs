using System;
using System.Linq;
using System.Threading.Tasks;
using VoiCoffee.Model;
using VoiCoffee.Services;
using VoiCoffee.Views;
using Xamarin.Essentials;
using Xamarin.Forms;
using static SQLite.SQLite3;

namespace VoiCoffee.ViewModels
{
    public class SignupViewModel : BaseViewModel
    {
        public Command LoginCommand { get; set; }
        public Command RegisterCommand { get; set; }

        private bool _IsBusy;
        public bool IsBusy
        {
            set
            {
                this._IsBusy = value;
                OnPropertyChanged();
            }
            get
            {
                return this._IsBusy;
            }
        }

        private int _Result;
        public int Result
        {
            set
            {
                this._Result = value;
                OnPropertyChanged();
            }
            get
            {
                return this._Result;
            }
        }

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
        private async Task LoginCommandAsync()
        {
            //navigate to LoginPage
            await Application.Current.MainPage.Navigation.PushModalAsync(new LoginView());
        }

        private async Task RegisterCommandAsync()
        {
            if (IsBusy)
                return;
            try
            {
                IsBusy = true;
                var userService = new UserService();
                Result = await userService.RegisterUser(Fullname, Username, Password, Address, Number);
                if (Result == 0)
                {
                    await Application.Current.MainPage.DisplayAlert("Thành Công", "Bạn Đã Đăng Ký Thành Công!", "OK");
                    await Application.Current.MainPage.Navigation.PushModalAsync(new LoginView());
                }
                else if (Result == 1)
                    await Application.Current.MainPage.DisplayAlert("Lỗi", "Tài Khoản Này Đã Tồn Tại!", "OK");
                else if (Result == 2)
                    await Application.Current.MainPage.DisplayAlert("Lỗi", "Vui Lòng Nhập Đầy Đủ Thông Tin!", "OK");

            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error", ex.Message, "OK");
            }
            finally
            {
                IsBusy = false;
            }
        }
        public SignupViewModel()
        {
            LoginCommand = new Command(async () => await LoginCommandAsync());
            RegisterCommand = new Command(async () => await RegisterCommandAsync());
        }
    }
}