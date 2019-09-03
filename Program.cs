using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter a number");

        int userNumber = int.Parse(Console.ReadLine());

        switch (userNumber)
        {
            case 10:
                Console.WriteLine("Your number is 10");
                break;
            case 20:
                Console.WriteLine("Your number is 20");
                break;
            case 30:
                Console.WriteLine("Your number is 30");
                break;
            default:
                Console.WriteLine("Your number is not 10, 20 or 30");
                break;
        }

    }
}
