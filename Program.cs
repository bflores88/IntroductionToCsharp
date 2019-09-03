using System;


class Program
{
    static void Main()
    {
        // Assignment operator: =
        int i = 10;
        bool b = true;
        
        // Arithmetic operators: +, -, *, /, %
        int Numerator = 10;
        int Denominator = 2;
        int Result = Numerator % Denominator;
        Console.WriteLine("Result = {0}", Result);
        
        // Comparison operators: ==, !=, >, >=, <, <=
        int Number = 10;
        if (Number == 10)
        {
            Console.WriteLine(true);
        }
        
        // Conditional operators: &&, ||
        int AnotherNumber = 20;
        if (Number == 10 || AnotherNumber != 20)
        {
            Console.WriteLine("Hello World");
        }
        
        // Ternary operator: ?
        bool isNumber10 = Number == 10 ? true : false;
        
        Console.WriteLine("Number == to is {0}", isNumber10);

    }
}