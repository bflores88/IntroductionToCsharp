using System;


class Program
{
    static void Main()
    {
        int i = 100;
        
        // float is bigger datatype than int. So, no loss of
        // data and exceptions. Hence implicit conversion
        float f = i;
        
        Console.WriteLine(f);

    }
}