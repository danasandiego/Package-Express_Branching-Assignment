using System;

namespace Package_Express_Branching_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight:");
            string weight = Console.ReadLine();
            int weight2 =Convert.ToInt32(weight);
            if (weight2 > 50) //checks user entry if greater than 50. terminates program if greater than 50.
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express.Have a good day.");
            }
            else //if less than 50, proceed to more entries
            {
                Console.WriteLine("Please enter the package width:");
                string width = Console.ReadLine();
                int width2 = Convert.ToInt32(width);  //casting string to integer
                Console.WriteLine("Please enter the package height:");
                string height = Console.ReadLine();
                int height2 = Convert.ToInt32(height);//casting string to integer
                Console.WriteLine("Please enter the package length:");
                string length = Console.ReadLine();
                int length2 = Convert.ToInt32(length);//casting string to integer
                decimal total = ((width2 * height2 * length2) * weight2) / 100; //formula to get total shipping fee

                Console.WriteLine("Your estimated total for shipping this package is: $" + total); //displays total
                Console.WriteLine("Thank you!");
            }




        }
    }
}
