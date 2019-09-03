using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter a number");

        int userNumber = int.Parse(Console.ReadLine());

        if (userNumber == 10 || userNumber == 20)
        {
            Console.WriteLine("Your number is 10 or 20");
        }

    }
}
