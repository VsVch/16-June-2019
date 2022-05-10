using System;

namespace _03._Movie_Destination
{
    class Program
    {
        static void Main(string[] args)
        {

            double budjet = double.Parse(Console.ReadLine());
            string destination = Console.ReadLine();
            string seson = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            double price = 0;
            double allPrice = 0;


            if (destination == "Dubai" && seson == "Winter")
            {
                price = 45000;
                price = price - price * 0.3;
            }
            else if (destination == "Dubai" && seson == "Summer")
            {
                price = 40000;
                price = price - price * 0.3;
            }
            else if (destination == "Sofia" && seson == "Winter")
            {
                price = 17000;
                price = price + price * 0.25;
            }
            else if (destination == "Sofia" && seson == "Summer")
            {

                price = 12500;
                price = price + price * 0.25;
            }
               
            
            else if (destination == "London" && seson == "Winter")
            {
                price = 24000;
            }
            else if (destination == "London" && seson == "Summer")
            {
                price = 20250;
            }

            allPrice = price * days;
            if (budjet >= allPrice)
            {
                Console.WriteLine($"The budget for the movie is enough! We have {(budjet - allPrice):f2} leva left!");
            }
            else
            {
                Console.WriteLine($"The director needs {(allPrice - budjet):f2} leva more!");
            }


        }
    }
}
