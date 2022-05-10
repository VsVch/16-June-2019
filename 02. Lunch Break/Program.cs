using System;

namespace _02._Lunch_Break
{
    class Program
    {
        static void Main(string[] args)
        {

            string nameMovie = Console.ReadLine();
            int coutinieMovie = int
                .Parse(Console.ReadLine());
            int timeRest = int.Parse(Console.ReadLine());

            double timeForLunch = timeRest/8.0;           // timeForLunch = Math.Ceiling(timeForLunch);
           // Console.WriteLine(timeForLunch);
            double timeForBreth = timeRest/4.0;
            //Console.WriteLine(timeForBreth);
           // timeForBreth = Math.Ceiling          (timeForBreth);
            double rest = timeRest-timeForLunch-timeForBreth;
            //rest = Math.Floor(rest);
            //rest = Math.Round(rest);
            //rest = Math.Ceiling(rest);

            //double ifis = Math.Abs(rest - coutinieMovie);

            //Console.WriteLine(rest);

            if (rest>=coutinieMovie)
            {
                Console.Write($"You have enough time to watch {nameMovie} and left with {Math.Ceiling (rest - coutinieMovie)} minutes free time.");
            }
            else
            {
                Console.Write($"You don't have enough time to watch {nameMovie}, you need {Math.Ceiling(coutinieMovie - rest)} more minutes.");
            }





        }
    }
}
