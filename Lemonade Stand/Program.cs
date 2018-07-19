using System;

namespace Lemonade_Stand
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Is This a Good idea?");
            Console.WriteLine();
            Console.WriteLine("What would you like your lemonade to be called?");
            String LemonadeStandName = Console.ReadLine();

            Console.WriteLine("Thank You, Your lemonade stand will be called " + LemonadeStandName);
            Console.WriteLine();
            Console.WriteLine("How many cups do you plan to sell?");

            int NumberOfCups = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Thank you");
            Console.WriteLine();
            Console.WriteLine("How much will you sell each cup for?");

            int PricePerCup = Int32.Parse(Console.ReadLine());

            int TotalRevenue = NumberOfCups * PricePerCup;

            Console.WriteLine("Your total revenue will be $ " + TotalRevenue);
            Console.WriteLine();

            Console.WriteLine("How much will your cost per cup be?");

            int CostPerCups = Int32.Parse(Console.ReadLine());
            Console.WriteLine();
            int CostOfCups = NumberOfCups * CostPerCups;
            int TotalProfit = TotalRevenue - CostOfCups;
            Console.WriteLine("Your Lemonade stand, " + LemonadeStandName + ", will have a Total Revenue of $" + TotalRevenue + " at a cost of $ " + CostOfCups);
            Console.WriteLine("Your profit will be $" + TotalProfit);
            Console.WriteLine("Does this sound good or bad?");
            Console.WriteLine();

            Console.WriteLine("Would you like to proceed?");
            string UserResponse = Console.ReadLine();





            Console.ReadLine();
        }
    }
}
