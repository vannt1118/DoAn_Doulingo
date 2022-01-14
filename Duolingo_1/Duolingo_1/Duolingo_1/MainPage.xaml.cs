using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Duolingo_1
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
            QuestionDatabase db = new QuestionDatabase();
            List<Question> lstq;
            lstq = db.SelectAllQuestions();
            if (lstq.Count == 0)
            {
                db.CreateQuestion();
            }
        }

        private void cmdstart_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TongQuan());
        }

        private void cmdtk_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SignIn());
        }
    }
}
