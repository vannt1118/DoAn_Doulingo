using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace do_an_1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BaiHocPage : ContentPage
    {
        Database db = new Database();
        User u;
        public BaiHocPage(User nd)
        {
            InitializeComponent();
            u = nd;
            Thu();
        }
        public BaiHocPage()
        {
            InitializeComponent();
            Thu();
            Navigation.PushAsync(new BaiHocPage(u));
        }
        void Thu()
        {
            List<GroupBH> dsgbh = new List<GroupBH>();
            GroupBH b1 = new GroupBH(1, new List<BaiHoc>
            {
                new BaiHoc
                {

                    TenBH = "Baby",
                    Hinh = "lesson_baby.png",
                    MaChang = 1,
                    ThanhTich = "crown_gray_stroke.png"

                },
                new BaiHoc
                {

                    TenBH = "Bag",
                    Hinh = "lesson_bag.png",
                    MaChang = 1,
                    ThanhTich = "crown_gray_stroke.png"
                },
                new BaiHoc
                {
                    TenBH = "Egg",
                    Hinh = "lesson_egg.png",
                    MaChang = 1,
                    ThanhTich = "crown_gray_stroke.png"

                }
            });
            dsgbh.Add(b1);

            GroupBH b2 = new GroupBH(2, new List<BaiHoc>
            {
                new BaiHoc
                {

                    TenBH = "Pencil",
                    Hinh = "lesson_pencil.png",
                    MaChang = 2,
                    ThanhTich = "crown_stroke.png"

                },
                new BaiHoc
                {

                    TenBH = "Bike",
                    Hinh = "lesson_bike.png",
                    MaChang = 2,
                    ThanhTich = "crown_gray_stroke.png"
                },
                new BaiHoc
                {
                    TenBH = "Hat",
                    Hinh = "lesson_hat.png",
                    MaChang = 2,
                    ThanhTich = "crown_stroke.png"

                }
            });
            dsgbh.Add(b2);
            lstbh.ItemsSource = dsgbh;


        }

        private void lstbh_ItemTapped(object sender, ItemTappedEventArgs e)
        {

        }

        private async void ImageButton_Clicked(object sender, EventArgs e)
        {
            
        }
    }
}