﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace do_an_1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignIn : ContentPage
    {
        Database db = new Database();
        public SignIn()
        {
            InitializeComponent();
        }

        private void cmdsubmit_Clicked(object sender, EventArgs e)
        {
            
            var ten = usrName.Text;
            var email = usrName.Text;
            var mk = usrPassword.Text;

            /*if (ten == "Ly" && mk == "8401")
            {
                DisplayAlert("Thông báo", "Chào Ly!", "Bắt đầu ngay");
                Navigation.PushAsync(new TabPage());
            }
            else*/
            if (db.XacThuc(ten, mk) == true)
            {
                User u = db.LayNd(ten);
                DisplayAlert("Thông báo", "Đăng nhập thành công", "OK");
                Navigation.PushAsync(new TabPage(u));
            }
            else
            {
                DisplayAlert("Thông báo", "Thông tin đăng nhập không chính xác", "OK");
                usrName.Text = "";
                usrPassword.Text = "";
                usrName.Focus();
            }
        }

        private void cmdfb_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TongQuan());
        }

        private void cmdgg_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TongQuan());
        }

        private void dk_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Taohs());
        }
    }
}