using System;
using System.Text;

class Program
{
    public static void Main()
    {
        Program.evenNumbers(30);
    }

    public static void evenNumbers(int target)
    {
        int start = 0;
        while (start <= target)
        {
            Console.WriteLine(start);
            start = start + 2;
        }
    }
}
