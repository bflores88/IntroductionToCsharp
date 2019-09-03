using System;
using System.Text;

class Program
{
    static void Main()
    {
        int totalCoffeeCost = 0;
        string userDecision = string.Empty;

        do
        {
            Console.WriteLine("Please Select Your Coffee Size: 1 - Small, 2 - Medium, 3 - Large");
            int userChoice = int.Parse(Console.ReadLine());

            switch (userChoice)
            {
                case 1:
                    totalCoffeeCost += 1;
                    break;
                case 2:
                    totalCoffeeCost += 2;
                    break;
                case 3:
                    totalCoffeeCost += 3;
                    break;
                default:
                    Console.WriteLine("Your choice {0} is invalid", userChoice);
                    break;
            }

            do
            {
                Console.WriteLine("Do you want to buy another coffee - Yes or No?");
                userDecision = Console.ReadLine();

                if (userDecision.ToUpper() != "YES" && userDecision.ToUpper() != "NO")
                {
                    Console.WriteLine("Your choice {0} is invalid.  Please try again...", userDecision);
                }
            } while (userDecision.ToUpper() != "YES" && userDecision.ToUpper() != "NO");
        } while (userDecision.ToUpper() != "NO");

        Console.WriteLine("Thank you for shopping with us");
        Console.WriteLine("Bill amount = {0}", totalCoffeeCost);

    }
}
