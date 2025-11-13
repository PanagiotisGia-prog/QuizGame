using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace QuizGame
{
    public class Quiz
    {
        private int _score;

        private Questions[] questions;

        public Quiz(Questions[] questions)
        {
            this.questions = questions;
            _score = 0;
        }

        public void StartGame()
        {
            Console.WriteLine("Welcome to the Quiz Game");
            int questionOrder = 1;

            foreach (Questions question in questions)
            {
                Console.WriteLine($"Question number {questionOrder++}:");
                SetQuestion(question);
                int user = GetUserChoice();
                if (question.CheckCorrectAnswer(user)) 
                {
                    Console.WriteLine("Correct!");
                    _score++;
                    Console.WriteLine("Press any key to continue...");
                    string anyKey = Console.ReadLine() ?? String.Empty;
                    Console.Clear();
                } 
                else
                {
                    Console.WriteLine($"Wrong! The correct answer was {question.Answers[question.CorrectAnswer]}");
                    Console.WriteLine("Press any key to continue...");
                    string anyKey = Console.ReadLine() ?? String.Empty;
                    Console.Clear();
                }
            }

            Console.WriteLine($"Quiz finisehd. Your final score is: {_score} out of {questions.Length}");
        }

        private void SetQuestion(Questions questions)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("ᒥ==============================================================================================ᒣ");
            Console.WriteLine("|                                        QUIZ GAME                                             |");
            Console.WriteLine("ᒪ==============================================================================================ᒧ");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(questions.QuestionText);

            for (int i = 0; i < questions.Answers.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("");
                Console.Write(i + 1 + ")");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($" {questions.Answers[i]}");
            }
        }
    
        public int GetUserChoice()
        {
            Console.WriteLine("Answer (Please use only numbers):");
            string? userInput = Console.ReadLine();
            int choiceIndex = 0;

            while(!int.TryParse(userInput, out choiceIndex) || choiceIndex < 1 || choiceIndex > 4) 
            {
                Console.WriteLine("Invalid choice. Please use a valid answer from 1-4");
                userInput = Console.ReadLine();
            }

            return choiceIndex - 1;
        }
    }
}
