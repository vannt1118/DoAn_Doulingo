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
    public partial class NdTruyenPage : ContentPage
    {
        async void LayTuTheoTruyen(truyen t)
        {
            HttpClient http = new HttpClient();
            var chuoi = await http.GetStringAsync("http://192.168.1.11/webapi/api/ServiceController/LayDsTuTheoTruyen?matruyen=" + t.Matruyen.ToString());
            List<tumoi> dstu = JsonConvert.DeserializeObject<List<tumoi>>(chuoi);
            lsttu.ItemsSource = dstu;
        }
        public NdTruyenPage()
        {
            InitializeComponent();
        }

        public NdTruyenPage(truyen t)
        {
            InitializeComponent();
            txtten.Text = t.Tentruyen;
            txtnd.Text = t.Noidung;
            LayTuTheoTruyen(t);
        }
        private void lsttu_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item != null)
            {
                tumoi t;
                t = (tumoi)e.Item;
                Navigation.PushAsync(new TuMoiPage(t));
            }
        }
    }
}