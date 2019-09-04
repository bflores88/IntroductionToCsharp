using System;
using System.Text;

class Program
{
    public static void Main()
    { 
        int i = 0;
        SimpleMethod(ref i);
        Console.WriteLine(i); // 0
        
        
    }

    public static void SimpleMethod(ref int j)
    {
        j = 101;
    }
}
