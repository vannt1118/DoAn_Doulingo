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
    public partial class MatKhauPage : ContentPage
    {
        Database db;
        User u;
        public MatKhauPage()
        {
            InitializeComponent();
            db = new Database();
        }

        public MatKhauPage(User nd)
        {
            InitializeComponent();
            db = new Database();
            u = nd;
        }

        private void txthuy_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }

        private void txtluu_Clicked(object sender, EventArgs e)
        {
            var mk = txtcu.Text;
            var moi = txtmoi.Text;
            var xn = txtxn.Text;

            if (mk != u.MatKhau)
            {
                DisplayAlert("Thông báo", "Mật khẩu hiện tại không đúng. Vui lòng nhập lại!", "Ok");
            }
            else if (moi != xn)
            {
                DisplayAlert("Thông báo", "Mật khẩu xác nhận không khớp.", "OK");
            }
            else
            {
                u.MatKhau = moi;
                if (db.SuaNguoiDung(u) == true)
                {
                    DisplayAlert("Thông báo", "Thay đổi mật khẩu thành công!", "OK");
                    Navigation.PopModalAsync();
                }
                else
                {
                    DisplayAlert("Thông báo", "Ghi lỗi", "OK");
                }
            }
        }
    }
}