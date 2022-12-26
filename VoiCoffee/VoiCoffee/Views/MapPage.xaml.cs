using System;
using System.Collections.Generic;
using VoiCoffee.Model;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace VoiCoffee.Views
{
    public partial class MapPage : ContentPage
    {
        public MapPage(Branch branch)
        {
            InitializeComponent();
            InitializeLoca(branch);
        }

        private void InitializeLoca(Branch branch)
        {
            Position position1 = new Position(branch.X, branch.Y);
            MapSpan mapSpan = new MapSpan(position1, 0.01, 0.01);
            map.MoveToRegion(mapSpan);

            Pin pin = new Pin
            {
                Label = "The Lagom Coffee",
                Address = branch.Address,
                Type = PinType.Place,
                Position = new Position(branch.X, branch.Y)
            };
            map.Pins.Add(pin);
        }

        async void ImageButton_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}
