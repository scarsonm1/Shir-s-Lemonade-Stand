using System;

namespace Lemonade_Stand
{
    class Program
    {
        static void Main(string[] args)
        {
            LemonadeStand stand = new LemonadeStand();

            Console.WriteLine("Is This a Good idea?");
            Console.WriteLine();
            Console.WriteLine("What would you like your lemonade to be called?");
            stand.Name = Console.ReadLine();

            Console.WriteLine("Thank You, Your lemonade stand will be called " + stand.Name);
            Console.WriteLine();
            Console.WriteLine("How many cups do you plan to sell?");

            stand.NumberOfCups = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Thank you");
            Console.WriteLine();
            Console.WriteLine("How much will you sell each cup for?");

            stand.PricePerCup = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Your total revenue will be $ " + stand.TotalRevenue());
            Console.WriteLine();

            Console.WriteLine("How much will your cost per cup be?");

            stand.CostPerCup = Int32.Parse(Console.ReadLine());
            Console.WriteLine();
            
            Console.WriteLine("Your Lemonade stand, " + stand.Name + ", will have a Total Revenue of $" + stand.TotalRevenue() + " at a cost of $ " + stand.TotalExpenses());
            Console.WriteLine("Your profit will be $" + stand.TotalProfit());
            Console.WriteLine("Does this sound good or bad?");
            Console.WriteLine();

            Console.WriteLine("Would you like to proceed?");
            string UserResponse = Console.ReadLine();

            Console.ReadLine();
        }
    }
}
