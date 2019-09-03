using System;
using System.Text;

class Program
{
    static void Main()
    {
     Console.WriteLine("Please enter your target");
     int userTarget = int.Parse(Console.ReadLine());

     int start = 10;

     while (start <= userTarget)
     {
         Console.Write(start + " ");
         start = start + 2;
     }
    }
}
