using System;
using System.Text;

class Program
{
    public static void Main()
    {
        Program.evenNumbers(30);
        
        Program p = new Program();
        int sum = p.Add(5, 5);
        
        Console.WriteLine("sum = {0}", sum);
    }

    public int Add(int fN, int sN)
    {
        return fN + sN;
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
