using System;

namespace _16_June_2019
{
    class Program
    {
        static void Main(string[] args)
        {

            string nameMovie = Console.ReadLine();
            int numSesions = int.Parse(Console.ReadLine());
            int numEpizodi = int.Parse(Console.ReadLine());
            double timeForOnes = double.Parse(Console.ReadLine());

            double reklami = timeForOnes * 0.2;
            double oneAndReklami = timeForOnes + reklami;
            double timeForSpecial = numSesions * 10;
            double sum = oneAndReklami * numEpizodi * numSesions + timeForSpecial;
            sum = Math.Floor(sum);
            Console.WriteLine($"Total time needed to watch the {nameMovie} series is {sum} minutes.");


        }
    }
}
