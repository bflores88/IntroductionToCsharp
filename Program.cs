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
            case 20:
            case 30:
                Console.WriteLine("Your number is {0}", userNumber);
                break;
            default:
                Console.WriteLine("Your number is not 10, 20 or 30");
                break;
        }

    }
}
