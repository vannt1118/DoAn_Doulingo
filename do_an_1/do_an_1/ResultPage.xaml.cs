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
    public partial class ResultPage : ContentPage
    {
        public ResultPage(int a)
        {
            InitializeComponent();
            lblscore.Text = "Điểm số của bạn là " + a + "/40";
        }

        private void btnfinish_Clicked(object sender, EventArgs e)
        {

        }
    }
}