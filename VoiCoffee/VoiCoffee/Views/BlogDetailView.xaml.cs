using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace VoiCoffee.Views
{
    public partial class BlogDetailView : ContentPage
    {
        public BlogDetailView(int num)
        {
            InitializeComponent();
            if (num == 3)
            {
                BigImg.Source = "https://file.hstatic.net/1000075078/file/_downloader.la_-61dfea3c26b86_4bc7e52295174fd3bd9bf0cfd72dc410_grande.jpg";
                Title.Text = "VĂN HOÁ THƯỞNG THỨC CÀ PHÊ CỦA NGƯỜI CHÂU Á";
                Con1.Text = "Văn hoá cà phê sẽ phụ thuộc vào những yếu tố liên quan đến “hình thái và phong cách” của làn sóng cà phê mà quốc gia đó chịu ảnh hưởng. Ngoài ra, chính nhịp sống, những đặc điểm riêng của mỗi vùng đất và sở thích, tính cách của những người dân bản địa sẽ quyết định trực tiếp đến văn hoá cà phê. Với những người dân châu Á sẽ có những nét văn hóa thưởng thức cà phê khác biệt so với người châu Âu hay châu Mỹ. Cùng xem những nét khác biệt và thú vị trong văn hóa thưởng thức cà phê của các nước châu Á nổi bật sau. ";
                Con2.Text = "Người Việt Nam thì chuộng cà phê sữa đá truyền thống, cà phê đen đá nguyên chất pha phin. Dù bất kỳ cửa hàng cà phê nào, từ sang trọng đến bình dân đều thấy sự hiện diện của nó. Với người Việt, cà phê là thức uống quen thuộc mỗi buổi sáng. Còn đối với người Sài Gòn thì cà phê lại được uống thường xuyên và bất kỳ thời gian nào trong ngày. Văn hóa đi cà phê chính là cách người Việt gặp gỡ, kết nối và gắn kết những người xung quanh. ";
                Con3.Text = "Có một nét đặc trưng thú vị trong văn hóa cà phê của người Việt đó là hình ảnh, phong cách uống cà phê ở những quán cà phê cóc, cà phê bệt, cà phê vỉa hè “ghế xanh, ghế đỏ” rất bình dị và mộc mạc. Đó là lúc người ta có thể xả hơi, ngắm nhìn phố xá, chuyện trò một cách thoải mái. Văn hoá cà phê này của người Việt cũng đã không ít lần được báo chí nước ngoài đưa tin.";
                Con4.Text = "Văn hoá cà phê của Hàn Quốc ngày càng “nữ hóa”. Đối tượng khách hàng chính của những quán cà phê của Hàn Quốc thường là phụ nữ trong độ tuổi 20 - 30. Đối với đàn ông Hàn Quốc việc đi cà phê tại quán khá “gượng gạo”, họ thường chọn trò chuyện với bạn bè khi chơi thể thao hay là những quán rượu. ";
                Con5.Text = "Phụ nữ Hàn có sở thích đi mua sắm, sau những chuyến shopping họ sẽ tán gẫu, nhâm nhi tách cà phê và thư giãn cùng bạn bè. Những không gian được trang trí đẹp mắt, ấn tượng sẽ ghi điểm lớn và được lui tới thường xuyên. Văn hóa thưởng thức cà phê của Hàn mang tính xã hội. Nếu ở Mỹ hay ngay cả ở Việt Nam, bạn có thể thấy những vị khách một mình đi cà phê với chiếc laptop hay sách, hoặc đi cùng ai đó nhưng lại bấm điện thoại thì ở Hàn Quốc lại không thế. Người Hàn đi cà phê với mục đích chính là để tương tác, trò chuyện và giao lưu với bạn bè. ";
                Sub1.Text = "Việt Nam";
                Sub2.Text = "Hàn Quốc";
                SmallImg1.Source = "https://file.hstatic.net/1000075078/file/_downloader.la_-61dfe7e232896_ef4676c1c85c414aa918bb0f07f1043b_grande.jpg";
                SmallImg2.Source = "https://file.hstatic.net/1000075078/file/_downloader.la_-61dfe8d440198_ad0a1849d48c448e9c3cc19733ac0e56_grande.jpg";
            }
            else
            if (num == 1)
            {
                BigImg.Source = "https://product.hstatic.net/1000075078/product/1637231136_original1-lifestyle-1_102a89f6e77742099ba8930c3716b0c2.jpg";
                Title.Text = "CÀ PHÊ ĐẬM ĐÀ CHO NGÀY DÀI NĂNG LƯỢNG";
                Con1.Text = "Cà phê là thức uống chiếm giữ vị trí số 1 trong lòng của rất rất nhiều người để mỗi ngày thêm cảm hứng, mỗi ngày thêm năng lượng và tràn đầy xúc cảm. The Coffee House dành một tình yêu sâu sắc với cà phê, luôn trân quý đối với từng vị khách, vậy nên không ngừng nỗ lực để đem đến những hương vị cà phê nguyên bản, thượng hạng, khuấy động vị giác và thoả mãn gu sành cà phê của các tín đồ.  ";
                Con2.Text = "Original 1, dòng sản phẩm cà phê rang xay được The Coffee House tinh tuyển từ những hạt Robusta của vùng đất Đắk Lắk nổi tiếng về cà phê. Giống cà phê được nuôi dưỡng bởi từng lớp đất đỏ bazan màu mỡ, đơm bông nhờ nắng, nhờ mưa của đất trời và trưởng thành từ đôi bàn tay cần mẫn của người nông dân yêu nghề. Để rồi cho ra đời những trái cà phê đỏ mọng, chất lượng tốt nhất, được chắt chiu thu hoạch, rang xay tỉ mỉ trước khi về với The Coffee House và trao tay khách hàng. ";
                Con3.Text = "Công nghệ rang xay hiện đại, được thực hiện nghiêm ngặt bởi những người thợ lành nghề, đã góp phần tạo nên hương vị đầy mê hoặc của Original 1. Tên gọi Original 1 đã nhằm khẳng định nó là sự tinh tuý của những hạt cà phê nguyên chất, không tẩm ướp, không pha trộn. Với 100% hạt Robusta Đắk Lắk đã tạo nên Original 1 mạnh mẽ, lôi cuốn, trọn vị đậm đà đầy lưu luyến. Một sản phẩm vừa thỏa mãn vị giác của tín đồ cà phê Việt, vừa tăng thêm uy tín của thương hiệu The Coffee House, vừa tôn vinh chất nguyên bản và giá trị vốn có của hạt cà phê núi rừng Đắk Lắk. ";
                Con4.Text = "Với cà phê rang xay Original 1 hảo hạng của The Coffee House, mỗi buổi sáng của bạn sẽ được bắt đầu đầy hứng khởi và thật tỉnh táo. Ngày dài bận rộn của bạn sẽ đầy ắp năng lượng và thú vị. Những ý tưởng mới sẽ được tuôn trào, sức sáng tạo càng được bung xõa. Tâm trạng của bạn sẽ phấn chấn, tươi tỉnh khi hương thơm của nó dậy lên một cách quyến rũ. Bởi vì, Original 1 đã được khẳng định là một hương vị nguyên chất, cực kỳ lôi cuốn, cực kỳ mãnh liệt được kiểm chứng và yêu thích bởi nhiều fans The Coffee House.";
                Con5.Text = "Thêm một điều nữa, những lúc bận rộn không thể ghé Nhà, với cà phê rang xay Original 1 bạn sẽ thật tiện để thưởng thức ly cà phê đậm đà gu truyền thống. Bạn có thể thử làm barista tại nhà thật dễ dàng mà vị cà phê lại thơm ngon, tuyệt vời như khi bạn thưởng thức tại quán. Original 1 sẽ cùng bạn có trải nghiệm cà phê theo cách riêng ở mọi lúc, mọi nơi.";
                Sub1.Text = "";
                Sub2.Text = "";
                SmallImg1.Source = "https://file.hstatic.net/1000075078/file/img_4749_9197dff67ab6477da5f7ddc0b9007eba_grande.jpg";
                SmallImg2.Source = "https://file.hstatic.net/1000075078/file/1_adccbb68c1c545a2852ab92a91c63aa0_grande.png";
            }
            else
            {
                BigImg.Source = "https://cdn.huongnghiepaau.com/wp-content/uploads/2019/01/dung-cu-chemex.jpg";
                Title.Text = "CÁCH PHA CÀ PHÊ PHIN THƠM NGON TRÒN VỊ";
                Con1.Text = "Có nhiều cách để pha một ly cà phê ngon, nhưng đối với nhiều người Việt giây phút đợi chờ những giọt cà phê rơi từ chiếc phin đã trở thành nét văn hóa ăn sâu trong tiềm thức. Để tạo nên một ly cà phê phin chuẩn vị, không chỉ cần sự tinh tế trong cách chọn loại cà phê mà còn cả sự tỉ mỉ trong từng bước pha.";
                Con2.Text = "Phin pha cà phê bao gồm các bộ phận như thân phin, nắp gài, đĩa lót đáy, nắp phin. Với chất liệu bằng nhôm hay inox sẽ có tác dụng giữ nóng nước pha cà phê và chắt lọc được những chất tinh túy nhất của cà phê. Đĩa lót đáy được đặt bên dưới thân phin với những lỗ siêu nhỏ sẽ giúp bột cà phê không lọt xuống ly, cho cảm nhận trọn vẹn khi uống.";
                Con3.Text = "Cà phê phin đặc biệt ở chỗ người ta có thể thưởng thức chậm rãi từ mùi thơm quyến rũ của cà phê rang xay đúng độ đến vị đắng nhẹ, đậm đà của từng giọt thấm nơi đầu lưỡi,... Trong khi đó, những cách pha cà phê khác với nhiều biến tấu, dễ làm vơi đi nguyên vị của cà phê.";
                Con4.Text = "Để có thể pha và nhâm nhi những ly cà phê phin thơm ngon, nồng đượm mỗi sáng tại nhà, khơi nguồn cho một ngày làm việc hiệu quả, bạn hãy chuẩn bị khoảng tầm 25g cà phê bột cùng 80 – 100ml nước, sau đó tiến hành pha cà phê phin theo các bước.";
                Con5.Text = "Ngoài ra, bạn nên lưu ý sử dụng phin pha cà phê bằng nhôm vì nó sẽ cho hương vị cà phê thơm ngon nhất. Đặc biệt, điều quan trọng nhất để có được những ly cà phê phin tuyệt vời đó là không quên lựa chọn loại cà phê chất lượng. Trên thị trường hiện nay có rất nhiều loại cà phê khác nhau, từ cà phê hạt đến cà phê bột, cà phê Moka, cà phê Robusta hay Arabica… The Coffee House giới thiệu bạn những dòng cà phê thượng hạng được ra đời từ mảnh đất bazan nắng gió Tây Nguyên. Tất cả đều được chế biến từ những hạt cà phê nguyên chất, đạt chuẩn về chất lượng và kỹ thuật rang xay, chế biến hiện đại nhất.";
                Sub1.Text = "Cà phê phin là gì";
                Sub2.Text = "Cách pha cà phê phin thơm ngon";
                SmallImg1.Source = "https://file.hstatic.net/1000075078/file/thecoffeehouse_caphe_5_94bce62bbba7450daed24cda2c6a196d_grande.jpeg";
                SmallImg2.Source = "https://file.hstatic.net/1000075078/file/final-2_c171692e77d94ca8b9144335a5f62749_grande.jpg";
            }
        }
        async void ImageButton_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}
