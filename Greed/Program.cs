using System;

namespace Greed
{
    class Program
    {
        static void Main(string[] args)
        {
            var g = new Game.Game();
            var playerRoll = g.RollDice();
            var playerScore = g.CalculateScore(playerRoll);
            playerRoll.ForEach(Console.WriteLine);
            Console.WriteLine("The player score is: ");
            Console.WriteLine(playerScore);
        }
    }
}
