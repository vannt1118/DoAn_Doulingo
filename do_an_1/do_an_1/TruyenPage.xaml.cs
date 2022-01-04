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
    public partial class TruyenPage : ContentPage
    {
        Database db = new Database();
        User u;
        public TruyenPage()
        {
            InitializeComponent();
            Thu();
        }

        public TruyenPage(User nd)
        {
            InitializeComponent();
            u = nd;
            txtdiem.Text = nd.Diem.ToString();
            txtten.Text = nd.TenND;

            Thu();

        }
        void Thu()
        {
            List<GroupTruyen> trs = new List<GroupTruyen>();
            GroupTruyen tr1 = new GroupTruyen("Familys", new List<Truyen>
            {
                new Truyen
                {
                    TenTruyen = "Family 1",
                    MaNhom = 1,
                    Hinh = "family_1.png"
                },
                new Truyen
                {
                    TenTruyen = "Family 2",
                    MaNhom = 1,
                    Hinh = "family_2.png"
                },
                new Truyen
                {
                    TenTruyen = "Family 3",
                    MaNhom = 1,
                    Hinh = "family_3.png"
                },
                new Truyen
                {
                    TenTruyen = "Family 4",
                    MaNhom = 2,
                    Hinh = "family_4.png"
                }
            });
            trs.Add(tr1);

            GroupTruyen tr2 = new GroupTruyen("The Owls", new List<Truyen>
            {
                new Truyen
                {
                    TenTruyen = "Owl 1",
                    MaNhom = 2,
                    Hinh = "owl_1.png"
                },
                new Truyen
                {
                    TenTruyen = "Owl 2",
                    MaNhom = 2,
                    Hinh = "owl_2.png"
                },
                new Truyen
                {
                    TenTruyen = "Owl 3",
                    MaNhom = 2,
                    Hinh = "owl_3.png"
                },
                new Truyen
                {
                    TenTruyen = "Owl 4",
                    MaNhom = 2,
                    Hinh = "owl_4.png"
                }
            });
            trs.Add(tr2);
            lsttr.ItemsSource = trs;
        }

        private void lsttr_ItemTapped(object sender, ItemTappedEventArgs e)
        {

        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {

        }
    }
}