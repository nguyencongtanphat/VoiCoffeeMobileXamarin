using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VoiCoffee.Model;
using Xamarin.Forms;

namespace VoiCoffee.Helpers
{
    public class AddFoodItemData
    {
        FirebaseClient client;
        public List<FoodItem> FoodItems { get; set; }
        public AddFoodItemData()
        {
            client = new FirebaseClient("https://coffeorderingapp-cef55-default-rtdb.asia-southeast1.firebasedatabase.app/");
            FoodItems = new List<FoodItem>() 
            {
                new FoodItem()
                {
                    ProductID=1,
                    CategoryID=1,
                    ImageUrl="MainBurger",
                    Name="Burger and Pizza hub 1",
                    Description="Burger - Pizza - Breakfast",
                    Rating="4.8",
                    RatingDetail=" (121 ratings)",
                    HomeSelected="CompleteHeart",
                    Price=45,
                },
                new FoodItem()
                {
                    ProductID=2,
                    CategoryID=2,
                    ImageUrl="MainPizza",
                    Name="Pizza",
                    Description=" Pizza - Breakfast",
                    Rating="4.3",
                    RatingDetail=" (120 ratings)",
                    HomeSelected="EmptyHeart",
                    Price=50,
                },
                 new FoodItem()
                {
                    ProductID=3,
                    CategoryID=3,
                    ImageUrl="MainDessert",
                    Name="Ice Creams",
                    Description=" Ice Creams - Breakfast",
                    Rating="4.3",
                    RatingDetail=" (120 ratings)",
                    HomeSelected="EmptyHeart",
                    Price=50,
                },
                new FoodItem()
                {
                    ProductID=4,
                    CategoryID=4,
                    ImageUrl="MainDessert",
                    Name="Cake",
                    Description=" Cake - Breakfast",
                    Rating="4.3",
                    RatingDetail=" (120 ratings)",
                    HomeSelected="EmptyHeart",
                    Price=50,
                },

            };
        }
        public async Task AddFoodItemsAsync()
        {
            try
            {
                foreach (var item in FoodItems)
                {
                    await client.Child("FoodItems").PostAsync(new FoodItem()
                    {
                        CategoryID = item.CategoryID,
                        ProductID = item.ProductID,
                        Description = item.Description,
                        HomeSelected = item.HomeSelected,
                        ImageUrl = item.ImageUrl,
                        Name = item.Name,
                        Price = item.Price,
                        Rating = item.Rating,
                        RatingDetail = item.RatingDetail,
                    });
                }
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error", ex.Message, "OK");
            }
        }

    }
}
