using System;
using System.Text;

class Program
{
    static void Main()
    {
        int totalCoffeeCost = 0;
        
        Start:
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
               goto Start;
       }
      
       Decide:
       Console.WriteLine("Do you want to buy another coffee - Yes or No?");
       string userDecision = Console.ReadLine();

       switch (userDecision.ToUpper())
       {
           case "YES":
               goto Start;
           case "NO":
               break;
           default:
               Console.WriteLine("Your choice is {0} invalid.  Please try again.", userDecision);
               goto Decide;
       }
       
       Console.WriteLine("Thank you for shopping with us");
       Console.WriteLine("Bill amount = {0}", totalCoffeeCost);
       
    }
}
