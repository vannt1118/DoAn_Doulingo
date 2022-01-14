﻿using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Duolingo_1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BatDauTest
    {
        BaiHoc b;
        User u;
        public BatDauTest()
        {
            InitializeComponent();
        }
        public BatDauTest(BaiHoc bh, User nd)
        {
            InitializeComponent();
            b = bh;
            u = nd;
            txtbh.Text = b.TenBH;
            img.Source = b.Hinh;
        }

        private void gotoTest_Clicked(object sender, EventArgs e)
        {
            if(b.MaBH != 1 && b.MaBH !=2 && b.MaBH !=3)
            {
                DisplayAlert("Thông báo", "Câu hỏi chưa được cập nhật. Vui lòng chọn bài học khác.", "OK");
            }   
            else
            {
                
                Navigation.PushModalAsync(new TestPage(b, u));
            
            }
            PopupNavigation.Instance.PopAsync();

        }
    }
}