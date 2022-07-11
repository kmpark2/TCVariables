using System;

namespace Variables_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string personName = "Michael";
            int personAge = 40;
            char personInitial = 'S';
            bool personBoss = true;
            double personDistance = 15.5;
            decimal personGas = 0.1m;

            Console.WriteLine($"{personName} {personInitial}. being the {personAge} yr-old boss of a paper comany is {personBoss}.");
            Console.WriteLine($"However, that boss is unable to go to the office which is {personDistance} miles away with only {personGas} gallon in the tank.");
        }
    }
}
