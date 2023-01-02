﻿using System;
using System.Threading.Tasks;
using VoiCoffee.Services;
using VoiCoffee.Views;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace VoiCoffee.ViewModels
{
    public class LogoutViewModel : BaseViewModel
    {
        private int _UserCartItemsCount;
        public int UserCartItemsCount
        {
            set
            {
                _UserCartItemsCount = value;
                OnPropertyChanged();
            }

            get
            {
                return _UserCartItemsCount;
            }
        }

        private bool _IsCartExists;
        public bool IsCartExists
        {
            set
            {
                _IsCartExists = value;
                OnPropertyChanged();
            }

            get
            {
                return _IsCartExists;
            }
        }

        public Command LogoutCommand { get; set; }
        public Command GotoCartCommand { get; set; }

        public LogoutViewModel()
        {
            UserCartItemsCount = new CartItemService().GetUserCartCount();

            IsCartExists = (UserCartItemsCount > 0) ? true : false;

            LogoutCommand = new Command(async () => await LogoutUserAsync());
            GotoCartCommand = new Command(async () => await GotoCartAsync());
        }

        private async Task GotoCartAsync()
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new CartView());
        }

        private async Task LogoutUserAsync()
        {
            var cis = new CartItemService();
            cis.RemoveItemsFromCart();
            Preferences.Remove("Username");
            Preferences.Remove("Fullname");
            Preferences.Remove("Address");
            Preferences.Remove("Phonenumber");
            await Application.Current.MainPage.Navigation.PushModalAsync(new LoginView());
        }
    }
}
