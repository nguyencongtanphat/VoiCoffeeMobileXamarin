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
                    CategoryName="Cà phê",
                    CategoryPoster="CaPhe",
                    ImageUrl="https://product.hstatic.net/1000075078/product/latte_851143_96ca362661644db5a1bb6563d1dfbe11.jpg"
                },
                new Category()
                {
                    CategoryID=2,
                    CategoryName="Trà trái cây",
                    CategoryPoster="TraTraiCay",
                    ImageUrl="https://product.hstatic.net/1000075078/product/1668574338_tra-dao-cam-sa_28487052296d4f85ab197868399ddde8.png"
                },
                new Category()
                {
                    CategoryID=3,
                    CategoryName="Trà sữa",
                    CategoryPoster="TraSua",
                    ImageUrl="https://product.hstatic.net/1000075078/product/hong-tra-latte_618293_12b6838bc4f349408d4f938a303d285c.jpg"
                },
                new Category()
                {
                    CategoryID=4,
                    CategoryName="Chocolate",
                    CategoryPoster="Chocolate",
                    ImageUrl="https://product.hstatic.net/1000075078/product/chocolatenong_949029_5eeb0c6d39a34903b8f2579b85b78524.jpg"
                },
                new Category()
                {
                    CategoryID=5,
                    CategoryName="Đóng chai",
                    CategoryPoster="DongChai",
                    ImageUrl="https://product.hstatic.net/1000075078/product/bottle_tradao_836487_ac6ab5fb3aa0417088ef724bec26f9c4.jpg"
                },
                new Category()
                {
                    CategoryID=6,
                    CategoryName="Bánh ngọt",
                    CategoryPoster="BanhNgot",
                    ImageUrl="https://product.hstatic.net/1000075078/product/1655348113_mochi-traxanh_aa9f4be54ef444f08d6428427ed2e938.jpg"
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
