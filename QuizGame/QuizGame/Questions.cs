using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGame
{
    public class Questions
    {
        public string QuestionText { get; set; }
        public string[] Answers { get; set; }
        public int CorrectAnswer { get; set; }
        public Questions(string question, string[] answers, int correctAnswer)
        {
            QuestionText = question;
            Answers = answers;
            CorrectAnswer = correctAnswer;
        }

        public bool CheckCorrectAnswer(int choice)
        {
            return CorrectAnswer == choice;
        }
    }
}
