using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");

        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squaredNumber = squareNumber(userNumber);
        DisplayResult(userName, squaredNumber);

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program.");
        }

        static string PromptUserName()
        {
            Console.Write($"Please enter your name: ");
            string name = Console.ReadLine();

            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write($"Please enter your favorite number: ");
            string userNumber = Console.ReadLine();
            int favoriteNumber = int.Parse(userNumber);

            return favoriteNumber;
        }
        
        static int squareNumber(int num)
        {
            int square = num * num;

            return square;
        }

        static void DisplayResult(string name, int square)
        {
            Console.WriteLine($"Hi, {name}! The square of your number is {square}.");
        }
    }
}