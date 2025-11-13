namespace QuizGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Questions[] questions = new Questions[]
            {
                new Questions(
                    "What is the primary purpose of the 'using' directive in C#?",
                    new string[] { "To declare variables", "To import namespaces", "To handle exceptions", "To define classes" },
                    1
                ),
                new Questions(
                    "In C#, what keyword is used to create a constant value that cannot be changed?",
                    new string[] { "static", "final", "const", "readonly" },
                    2
                ),
                new Questions(
                    "Which of the following is a value type in C#?",
                    new string[] { "String", "Array", "Int", "Object" },
                    2
                ),
                new Questions(
                    "What does the 'virtual' keyword allow in C# methods?",
                    new string[] { "Method overloading", "Static method calls", "Inline execution", "Method overriding in derived classes" },
                    3
                ),
                new Questions(
                    "In C#, how do you declare an array of integers?",
                    new string[] { "int[] numbers;", "array<int> numbers;", "int numbers[];", "list<int> numbers;" },
                    0
                ),
                new Questions(
                    "What is the base class for all classes in C#?",
                    new string[] { "System.Base", "System.Object", "System.Type", "System.Root" },
                    1
                )

            };

            

            Quiz quiz = new Quiz(questions);
            quiz.StartGame();
            

            Console.ReadKey();
        }
    }
}
