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
    public partial class ChinhSuaPage : ContentPage
    {
        Database db = new Database();
        User u;
        public ChinhSuaPage()
        {
            InitializeComponent();
        }
        public ChinhSuaPage(User nd)
        {
            InitializeComponent();
            u = nd;
            HienThi();
        }

        void HienThi()
        {
            if (u != null)
            {
                txtmand.Text = u.MaND.ToString();
                txtten.Text = u.TenND; ;
                txtemail.Text = u.Email;
                txthinh.Text = u.Hinh;
            }    
        }
        private async void btnhuy_Clicked(object sender, EventArgs e)
        {
            var ans = await DisplayAlert("Thông báo", "Thay đổi của bạn sẽ không được lưu lại. Bạn có chắc muốn hủy?", "Yes", "No");
            if (ans)
            {
                Navigation.PopAsync();
            }    
        }

        private void btnluu_Clicked(object sender, EventArgs e)
        {
            var t = txtten.Text;
            var h = txthinh.Text;
            var eml = txtemail.Text;

            User u1 = new User { TenND = txtten.Text, Email = txtemail.Text, Hinh = txthinh.Text };
            if(txtmand.Text != "")
            {
                u1.MaND = int.Parse(txtmand.Text);
                if (db.SuaNguoiDung(u1) == true)
                {
                    DisplayAlert("Thông báo", "Cập nhật thông tin thành công", "OK");
                    Navigation.PushAsync(new NguoiDungPage(u1));
                }
                else
                    DisplayAlert("Thông báo", "Ghi lỗi", "OK");
            }    
            
        }

        private void btnmk_Clicked(object sender, EventArgs e)
        {
            img.Source = txthinh.Text;
        }

        private void btndx_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
            Navigation.RemovePage(this);
        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            txthinh.Focus();
        }
    }
}