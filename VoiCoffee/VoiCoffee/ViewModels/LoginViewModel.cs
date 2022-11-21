using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VoiCoffee.Services;
using VoiCoffee.Views;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace VoiCoffee.ViewModels
{
    public class LoginViewModel : BaseViewModel
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

        private bool _Result1;
        public bool Result1
        {
            set
            {
                this._Result1 = value;
                OnPropertyChanged();
            }
            get
            {
                return this._Result1;
            }
        }

        public Command LoginCommand { get; set; }  
        public Command RegisterCommand { get; set; }
        public LoginViewModel()
        {
            LoginCommand = new Command(async () => await LoginCommandAsync());
            RegisterCommand = new Command(async () => await RegisterCommandAsync());
        }

        private async Task RegisterCommandAsync()
        {
            if (IsBusy)
                return;
            try
            {
                IsBusy = true;
                var userService = new UserService();
                Result = await userService.RegisterUser(Username, Password);
                if (Result == 0)
                {
                    await Application.Current.MainPage.DisplayAlert("Thành Công", "Bạn Đã Đăng Ký Thành Công!", "OK");
                }
                else if (Result ==1)
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

        private async Task LoginCommandAsync()
        {
            if (IsBusy)
                return;
            try
            {
                IsBusy = true;
                var userService = new UserService();
                Result1 = await userService.LoginUser(Username, Password);
                if (Result1)
                {
                    Preferences.Set("Username", Username);
                    await Application.Current.MainPage.Navigation.PushModalAsync(new ProductsView());
                }
                else
                    await Application.Current.MainPage.DisplayAlert("Lỗi", "Tài Khoản hoặc Mật Khẩu Chưa Đúng!", "OK");
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
    }
}
