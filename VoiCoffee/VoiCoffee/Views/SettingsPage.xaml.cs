using System;
using System.Collections.Generic;
using VoiCoffee.Helpers;
using Xamarin.Forms;

namespace VoiCoffee.Views
{
    public partial class SettingsPage : ContentPage
    {
        public SettingsPage()
        {
            InitializeComponent();
        }

        async void ButtonCategories_Clicked(System.Object sender, System.EventArgs e)
        {
            var acd = new AddCategoryData();
            await acd.AddCategoriesAsync();
        }

        async void ButtonProducts_Clicked(System.Object sender, System.EventArgs e)
        {
            var afd = new AddFoodItemData();
            await afd.AddFoodItemsAsync();
        }

        void ButtonCart_Clicked(System.Object sender, System.EventArgs e)
        {
            var cct = new CreatCartTable();
            if (cct.CreateTable())
                DisplayAlert("Success", "Cart Table Created", "OK");
            else
                DisplayAlert("Error", "Error while creating table", "OK");
        }
    }
}
