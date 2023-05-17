using System;
using System.Runtime.ConstrainedExecution;
using RPGSaga.Classes.Game;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter the desired number of heroes: ");
        string number = Console.ReadLine();

        // Parse the input string into an integer
        if (int.TryParse(number, out int numberOfHeroes))
        {
            Game newGame = new Game(numberOfHeroes);
            newGame.Run(numberOfHeroes);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
}
