using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Duolingo_1
{
    public class QuestionDatabase
    {
        string folder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
        public bool CreateDatabase()
        {
            try
            {
                var connect = new SQLiteConnection(System.IO.Path.Combine(folder, "Questions.db"));
                connect.CreateTable<Question>();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public List<Question> SelectQuestions(int i)
        {
            try
            {
                var connect = new SQLiteConnection(System.IO.Path.Combine(folder, "Questions.db"));
                return connect.Table<Question>().Where(t=>t.Lessonid==i).ToList();
            }
            catch
            {
                return null;
            }
        }
        public List<Question> SelectAllQuestions()
        {
            try
            {
                var connect = new SQLiteConnection(System.IO.Path.Combine(folder, "Questions.db"));
                return connect.Table<Question>().ToList();
            }
            catch
            {
                return null;
            }
        }

        public List<Question> Select4Questions()
        {
            try
            {
                var connect = new SQLiteConnection(System.IO.Path.Combine(folder, "Questions.db"));
                return connect.Query<Question>("select * from Question limit 4");
            }
            catch
            {
                return null;
            }
        }
        public bool InsertQuestion(Question q)
        {
            try
            {
                var connect = new SQLiteConnection(System.IO.Path.Combine(folder, "Questions.db"));
                connect.Insert(q);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public Question SelectQuestion(int i)
        {
            try
            {
                var connect = new SQLiteConnection(System.IO.Path.Combine(folder, "Questions.db"));
                return connect.Table<Question>().FirstOrDefault(t => t.Id == i);
            }
            catch
            {
                return null;
            }
        }
        public bool UpdateQuestion(Question q)
        {
            try
            {
                var connect = new SQLiteConnection(System.IO.Path.Combine(folder, "Questions.db"));
                connect.Update(q);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DeleteQuestion(Question q)
        {
            try
            {
                var connect = new SQLiteConnection(System.IO.Path.Combine(folder, "Questions.db"));
                connect.Delete(q);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
