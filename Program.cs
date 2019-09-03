using System;


class Program
{
    static void Main()
    {
        bool? AreYouMajor = null;

        if (AreYouMajor == true)
        {
            Console.WriteLine("User is a Major");
        } else if (AreYouMajor == false)
        {
            Console.WriteLine("User is Not Major");
        }
        else
        {
            Console.WriteLine("User did not answer the question");
        }
    }
}