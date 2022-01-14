using System;
using System.Collections.Generic;
using System.Text;

namespace Duolingo_1
{
    public class Questionnaire : QuestionBuilder
    {
        public override void Building(Question q)
        {
            QuestionQuiz.setting_question(q);
        }
    }
}
