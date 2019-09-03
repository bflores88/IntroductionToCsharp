using System;
using System.Text;

class Program
{
    static void Main()
    {
        string userChoice = string.Empty;
        
        do
        {
            Console.WriteLine("Please enter your target");
            int userTarget = int.Parse(Console.ReadLine());

            int start = 0;

            while (start <= userTarget)
            {
                Console.Write(start + " ");
                start = start + 2;
            }

            do
            {
                Console.WriteLine("\nDo you want to continue - Yes or No?");

                userChoice = Console.ReadLine().ToUpper();

                if (userChoice != "YES" && userChoice != "NO")
                {
                    Console.WriteLine("Invalid choice, please say Yes or No");
                }
            } while (userChoice != "YES" && userChoice != "NO");
        } while (userChoice == "YES");
    }
}
