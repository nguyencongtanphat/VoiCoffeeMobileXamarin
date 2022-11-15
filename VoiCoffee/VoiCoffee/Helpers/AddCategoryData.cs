using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VoiCoffee.Model;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace VoiCoffee.Helpers
{

    public class AddCategoryData
    {
        public List<Category> Categories { get; set; }

        FirebaseClient client;
        public AddCategoryData()
        {
            client = new FirebaseClient("https://coffeorderingapp-cef55-default-rtdb.asia-southeast1.firebasedatabase.app/");
            Categories = new List<Category>()
            {
                new Category()
                {
                    CategoryID=1,
                    CategoryName="Burger",
                    CategoryPoster="MainBurger",
                    ImageUrl="https://upload.wikimedia.org/wikipedia/commons/thumb/4/47/Hamburger_%28black_bg%29.jpg/800px-Hamburger_%28black_bg%29.jpg"
                },
                new Category()
                {
                    CategoryID=2,
                    CategoryName="Pizza",
                    CategoryPoster="MainPizza",
                    ImageUrl="https://upload.wikimedia.org/wikipedia/commons/thumb/4/47/Hamburger_%28black_bg%29.jpg/800px-Hamburger_%28black_bg%29.jpg"
                },
                new Category()
                {
                    CategoryID=3,
                    CategoryName="Desserts",
                    CategoryPoster="MainDesserts",
                    ImageUrl="https://upload.wikimedia.org/wikipedia/commons/thumb/4/47/Hamburger_%28black_bg%29.jpg/800px-Hamburger_%28black_bg%29.jpg"
                },
                new Category()
                {
                    CategoryID=4,
                    CategoryName=" Veg Burger",
                    CategoryPoster="MainBurger",
                    ImageUrl="https://upload.wikimedia.org/wikipedia/commons/thumb/4/47/Hamburger_%28black_bg%29.jpg/800px-Hamburger_%28black_bg%29.jpg"
                },
                new Category()
                {
                    CategoryID=5,
                    CategoryName="Veg Pizza",
                    CategoryPoster="MainPizza",
                    ImageUrl="https://upload.wikimedia.org/wikipedia/commons/thumb/4/47/Hamburger_%28black_bg%29.jpg/800px-Hamburger_%28black_bg%29.jpg"
                },
                new Category()
                {
                    CategoryID=6,
                    CategoryName="Cakes",
                    CategoryPoster="MainDesserts",
                    ImageUrl="https://upload.wikimedia.org/wikipedia/commons/thumb/4/47/Hamburger_%28black_bg%29.jpg/800px-Hamburger_%28black_bg%29.jpg"
                },
            };

        }
        public async Task AddCategoriesAsync()
        {
            try
            {
                foreach(var category in Categories)
                {
                    await client.Child("Categories").PostAsync(new Category()
                    {
                        CategoryID = category.CategoryID,
                        CategoryName = category.CategoryName,
                        CategoryPoster=category.CategoryPoster,
                        ImageUrl = category.ImageUrl,
                    }) ;
                }
            }
            catch( Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error", ex.Message, "OK");
            }
        }
    }
}
