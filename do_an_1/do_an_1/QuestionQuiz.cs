using System;
using System.Collections.Generic;
using System.Text;

namespace do_an_1
{
    public class QuestionQuiz
    {
        protected QuestionBuilder questions;

        public void SetQuestionsBuilder(QuestionBuilder question) { questions = question; }

        public Question GettingQuestions() { return questions.gettingQuestion(); }

        public void BuildingQuestions()
        {
            questions.CreateInstance();

        }

    }
}
