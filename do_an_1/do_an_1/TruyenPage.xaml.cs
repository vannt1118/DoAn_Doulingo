using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
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
            //Thu();
        }

        public TruyenPage(User nd)
        {
            InitializeComponent();
            u = nd;
            HienThiDsTruyen();
            HienThi(nd);
            //KhoiTao();

        }
        void HienThi(User nd)
        {
            txtdiem.Text = nd.Diem.ToString();
            txtten.Text = nd.TenND;
           
        }
        async void HienThiDsTruyen()
        {
            HttpClient http = new HttpClient();
            var chuoi = await http.GetStringAsync("http://192.168.1.11/wepapidoan/api/ServiceController/LayDsTruyen");
            var dstr = JsonConvert.DeserializeObject<List<truyen>>(chuoi);
            lsttr.ItemsSource = dstr;   
        }
        /*
        void KhoiTao()
        {
            List<Truyen> trs = new List<Truyen>
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
                },


            };
            lsttr.ItemsSource = trs;
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
        }*/

        private void lsttr_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            User u1 = db.LayNd(u.TenND);

            HienThi(u1);
        }

        
    }
}