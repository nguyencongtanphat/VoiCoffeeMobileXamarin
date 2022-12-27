using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using VoiCoffee.Model;

namespace VoiCoffee.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductsView : ContentPage
    {
        public ProductsView()
        {
            InitializeComponent();
            InitializeStory();
        }

        async void CollectionView_SelectionChanged(System.Object sender, Xamarin.Forms.SelectionChangedEventArgs e)
        {
            var category = e.CurrentSelection.FirstOrDefault() as Category;
            if (category == null)
                return;
            await Navigation.PushModalAsync(new CategoryView(category));

            ((CollectionView)sender).SelectedItem = null;
        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            Category category = new Category() { CategoryID = 3, CategoryName = "Trà Sữa", CategoryPoster = "http://file.hstatic.net/1000075078/article/hong_tra_sua_tran_chau_da_lifestyle_f00b4d9af46149eead2abf629ce1d901.jpg", ImageUrl = "https://product.hstatic.net/1000075078/product/hong-tra-latte_618293_12b6838bc4f349408d4f938a303d285c.jpg" };
            await Navigation.PushModalAsync(new CategoryView(category));
        }

        private void InitializeStory()
        {
            List<Story> branchList = new List<Story>();
            branchList.Add(new Story
            {
                StoryId = 1,
                StoryName = "Cà phê đậm đà cho ngày dài năng lượng",
                StoryShort = "Cà phê là thức uống chiếm giữ vị trí số 1 trong lòng của rất rất nhiều người để mỗi ngày thêm cảm hứng, mỗi ngày thêm năng lượng và tràn đầy xúc cảm...",
                StoryImage = "https://product.hstatic.net/1000075078/product/1637231135_original1-lifestyle-3_cd72feaaba16429084e8d6f98b15dc10.jpg",
            });
            branchList.Add(new Story
            {
                StoryId = 2,
                StoryName = "Cà phê đậm đà cho ngày dài năng lượng",
                StoryShort = "Cà phê là thức uống chiếm giữ vị trí số 1 trong lòng của rất rất nhiều người để mỗi ngày thêm cảm hứng, mỗi ngày thêm năng lượng và tràn đầy xúc cảm...",
                StoryImage = "https://product.hstatic.net/1000075078/product/1637231135_original1-lifestyle-3_cd72feaaba16429084e8d6f98b15dc10.jpg",
            });
        }

        async void ImageButton_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new BlogDetailView(1));
        }

        async void ImageButton_Clicked_1(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new BlogDetailView(2));
        }

        async void ImageButton_Clicked_2(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new BlogDetailView(3));
        }
    }
}