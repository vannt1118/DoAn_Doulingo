using System;
using System.Collections.Generic;
using System.Text;

namespace do_an_1
{
    public abstract class QuestionBuilder
    {
        protected Question QuestionQuiz;
        public Question gettingQuestion() { return QuestionQuiz; }

        public void CreateInstance() { QuestionQuiz = new Question(); }

        public abstract void Building(Question question);

    }
}
