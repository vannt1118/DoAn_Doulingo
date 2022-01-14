using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Duolingo_1
{
    public partial class Page2 : ContentPage
    {
        QuestionDatabase db;
        Question q;
        public Page2()
        {
            InitializeComponent();
            db = new QuestionDatabase();
            
            ShowQuestions();
        }
        /*
        void KhoiTao()
        {
            List<Question> qs;
            qs = db.SelectAllQuestions();
            lstquestion.ItemsSource = qs;
        }

        void ShowQuestions()
        {
            if (q != null)
            {
                txtid.Text = q.Id.ToString();
                txtlessonid.Text = q.Lessonid.ToString();
                txtques.Text = q.Quest_;
                txtresp1.Text = q.resp1_;
                txtresp2.Text = q.resp2_;
                txtresp3.Text = q.resp3_;
                txtresp4.Text = q.resp4_;
                txtcorrect.Text = q.Correct;
            }
        }*/

        void ShowQuestions()
        {
            List<Question> lstq;
            lstq = db.SelectAllQuestions();
            if (lstq.Count == 0)
            {
                db.CreateQuestion();
            }    
            lstquestion.ItemsSource = lstq;
        }
       
        private void them_Clicked(object sender, EventArgs e)
        {
            txtid.Text = "";
            txtlessonid.Text = "";
            txtques.Text = "";
            txtresp1.Text = "";
            txtresp2.Text = "";
            txtresp3.Text = "";
            txtresp4.Text = "";
            txtcorrect.Text = "";

            txtlessonid.Focus();
        }

        private void ghi_Clicked(object sender, EventArgs e)
        {
            Question q = new Question { Lessonid = int.Parse(txtlessonid.Text), Quest_ = txtques.Text, resp1_ = txtresp1.Text, resp2_ = txtresp2.Text, resp3_ = txtresp3.Text, resp4_ = txtresp4.Text, Correct = txtcorrect.Text };
            
            if (txtid.Text == null)
            {
                DisplayAlert("Thông báo", "Hãy thêm câu hỏi trước", "OK");
                ShowQuestions();
            }
            else if (txtid.Text != "")
            {
                q.Id = int.Parse(txtid.Text);
                if (db.UpdateQuestion(q) == true)
                {
                    DisplayAlert("Thông báo", "Cập nhật thành công", "OK");
                    ShowQuestions();
                }
                else DisplayAlert("Thông báo", "Ghi lỗi", "OK");
            }
            else
            {
                if (db.InsertQuestion(q) == true)
                {
                    DisplayAlert("Thông báo", "Thêm thành công", "OK");
                    ShowQuestions();
                }
                else DisplayAlert("Thông báo", "Thêm không thành công", "OK");
            }
        }

        private void khongghi_Clicked(object sender, EventArgs e)
        {
            Question q = new Question();
            q.Lessonid = 1;
            q.Quest_ = "cau1";
            q.resp1_ = "a";
            q.resp1_ = "b";
            q.resp1_ = "c";
            q.resp1_ = "d";
            q.Correct = "a";
            if (db.InsertQuestion(q) == true)
            {
                DisplayAlert("Thông báo", "Thêm thành công", "OK");
                ShowQuestions();
            }
            else DisplayAlert("Thông báo", "Thêm không thành công", "OK");
        }

        private async void xoa_Clicked(object sender, EventArgs e)
        {
            if (q == null)
                return;
            var ask = await DisplayAlert("Thông báo", "Xóa câu hỏi này?", "Yes", "No");
            if (ask)
            {
                if (db.DeleteQuestion(q))
                {
                    await DisplayAlert("Thông báo", "Xóa thành công", "OK");
                    ShowQuestions();
                }
                else
                    await DisplayAlert("Thông báo", "Xóa lỗi", "OK");

            }
        }

        private void lstquestion_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item != null)
            {
                q = (Question)e.Item;
            }
        }
    }
}