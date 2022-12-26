using System;
using System.Collections.Generic;
using VoiCoffee.Model;
using Xamarin.Forms;

namespace VoiCoffee.Views
{
    public partial class BranchView : ContentPage
    {
        public BranchView()
        {
            InitializeComponent();
            InitializeBranch();
        }
        private void InitializeBranch()
        {
            List<Branch> branchList = new List<Branch>();
            branchList.Add(new Branch { BranchId = 1, Province = "Chi nhánh: quận Thủ Đức", Address = "213 Hàn Thuyên, quận Thủ Đức, Tp. Hồ Chí Minh", X = 10.870936095981785, Y = 106.80301118465555,
                Img = "http://file.hstatic.net/1000075078/article/2_c7d67b2212114f29a2db4e0b6643825e.jpg"
            });
            branchList.Add(new Branch { BranchId = 2, Province = "Chi nhánh: quận Bình Thạnh", Address = "18 Xô Viết Nghệ Tĩnh, quận Bình Thạnh, Tp. Hồ Chí Minh", X = 10.810676408851197, Y = 106.71334893730936,
                Img = "https://cdn.brvn.vn/topics/1280px/2022/327150_Seedcom-cover_1661833154.jpg"
            });
            branchList.Add(new Branch { BranchId = 3, Province = "Chi nhánh: quận Gò Vấp", Address = "119 Lê Văn Thọ, quận Gò Vấp, Tp, Hồ Chí Minh", X = 10.845351360026616, Y = 106.65516262314242,
                Img = "https://danviet.mediacdn.vn/2021/4/13/the-coffee-house-khong-nhuong-nguyen-1618324271848672760365-crop-1618324294521246672359.jpg"
            });
            branchList.Add(new Branch { BranchId = 4, Province = "Chi nhánh: quận 1", Address = "20/2 Đinh Tiên Hoàn, quận 1, Tp. Hồ Chí Minh", X = 10.790048, Y = 106.698532,
                Img = "https://cdn.vietnambiz.vn/171464876016439296/2021/10/30/seedcom-16356130820051710517369.jpeg"
            });
            branchList.Add(new Branch { BranchId = 5, Province = "Chi nhánh: quận 7", Address = "53 Tân Kiến Tạo, quận 7, Tp. Hồ Chí Minh", X = 10.735052, Y = 106.714952,
                Img = "https://file.hstatic.net/1000075078/file/_kh_9706_725472c8dda54d0ca33e46a104359907_master.jpg"
            });
            LstBranch.ItemsSource = branchList;

        }

        async void ImageButton_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        private async void LstBranch_ItemTapped(System.Object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
            if (LstBranch.SelectedItem != null)
            {
                Branch branch = (Branch)LstBranch.SelectedItem;
                await Navigation.PushModalAsync(new MapPage(branch));
            }
        }
    }
}
