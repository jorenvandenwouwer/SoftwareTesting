using System;

namespace UnitTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberGame = new NumberGame();
            var score = numberGame.RateGuess(5);
            Console.WriteLine($"uw score: {score}");
        }
    }
}
