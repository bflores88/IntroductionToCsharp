using System;
using System.Text;

class Program
{
    static void Main()
    {
        // break statement causes the control to get out of the loop
        for (int i = 1; i <= 20; i++)
        {
            Console.WriteLine(i);
            
            if(i==10) break;
        }
        
        // continue statement will end code execution in the for loop and start again at the next increment
        for (int j = 0; j <= 20; j++)
        {
            if(j%2 == 1) continue;
            Console.WriteLine(j);
        }
    }
}
