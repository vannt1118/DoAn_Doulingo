﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Duolingo_1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TongQuan : ContentPage
    {
        public TongQuan()
        {
            InitializeComponent();
        }

        private void continue_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MucTieu());
        }
    }
}