using System;
using System.Text;

class Program
{
    public static void Main()
    {
        int[] numbers = new int[] {101, 102, 103};
        
        ParamsMethod();
        ParamsMethod(numbers);
        ParamsMethod(1, 2, 3, 4, 5);
        
    }

    public static void ParamsMethod(params int[] numbers)
    {
        Console.WriteLine("There are {0} elements", numbers.Length);
        foreach (int i in numbers)
        {
            Console.WriteLine(i);
        }
    }

}
