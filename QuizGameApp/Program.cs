namespace QuizGameApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] questions = new string[5]
            {
                "1. What is the capital of Italiy ?",
                "2. What is the red planet ?",
                "3. What is the largest animals ?",
                "4. What is the smallest continent?",
                "5. What is the chemical symbol for water?"

            };
            string[] answers = new string[5]
            {
                "Roma",
                "Mars",
                "Whale",
                "Australia",
                "H2O"
            };
            int correctAnswer = 0;
            Console.WriteLine("Welcome to the game!");
            Console.WriteLine("*********************");
            Console.WriteLine("\nPlease answer the following questions:");

            for (int i = 0; i < questions.Length; i++)
            {
                Console.WriteLine(questions[i]);
                string userAnswers = Console.ReadLine();

                try
                {
                    bool result = IsTheAnswerCorrect(userAnswers, answers[i]);
                    if (result == true)
                    {
                        Console.WriteLine("Correct Answer");
                        correctAnswer++;
                    }

                    else
                    Console.WriteLine($"Sorry, Incorrect answer. The corect answer is {answers[i]}");
               }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.WriteLine($"Your score is {correctAnswer}");
            Console.WriteLine("Quiz completed, Thank you for playing");

        }
        private static bool IsTheAnswerCorrect(string userInput, string correctAnswer)
        {
            if(string.IsNullOrEmpty(userInput))
            {
                throw new Exception("Answer cant be empty");
            }
            //if (userInput == correctAnswer)
            //    return true;
            //else
            //    return false;
            return string.Equals(userInput.Trim(), correctAnswer, StringComparison.OrdinalIgnoreCase);
        }
    }
}
