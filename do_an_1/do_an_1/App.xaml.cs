using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace do_an_1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Database db = new Database();
            db.CreateDatabase();

            // MainPage = new NavigationPage(new MainPage());
            MainPage = new Page2();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
