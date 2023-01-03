using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace VoiCoffee.Views
{
    public partial class UpdateUserView : ContentPage
    {
        public UpdateUserView()
        {
            InitializeComponent();
        }
        async void ImageButton_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}
