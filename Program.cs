using System;
using System.Text;

class Program
{
    public static void Main()
    { 
        int i = 0;
        SimpleMethod(i);
        Console.WriteLine(i); // 0
        
        
    }

    public static void SimpleMethod(int j)
    {
        j = 101;
    }
}
