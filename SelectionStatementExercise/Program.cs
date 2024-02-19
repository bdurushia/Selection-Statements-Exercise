using System.Security.Cryptography.X509Certificates;

namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1

            Random randomNumber = new Random();
            int favNumber = randomNumber.Next(1, 11);

            Console.WriteLine("Guess my favorite number:");
            int userGuess = int.Parse(Console.ReadLine());

            if (userGuess < favNumber)
            {
                Console.WriteLine("Too low!");
            }
            else if (userGuess > favNumber) 
            {
                Console.WriteLine("Too high!");
            }
            else
            { 
                Console.WriteLine("You guessed it!!!");
            }
        }
    }
}
