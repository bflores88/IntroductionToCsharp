using System;
using System.Text;

class Program
{
    public static void Main()
    {
        Program p = new Program();
        p.evenNumbers();
    }

    public void evenNumbers()
    {
        int start = 0;
        while (start <= 20)
        {
            Console.WriteLine(start);
            start = start + 2;
        }
    }
}
