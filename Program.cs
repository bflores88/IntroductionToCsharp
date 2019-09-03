using System;
class Program
{
    static void Main()
    {
        int[] evenNumbers = new int[3];

        evenNumbers[0] = 0;
        evenNumbers[1] = 2;
        evenNumbers[2] = 4;
        
        Console.WriteLine(evenNumbers[1]);
        
        // Advantages: strongly typed
        // Disadvantages: cannot grow in size once initialized; have to rely on integral indices to store/retrieve items from array
    }
}