using System;
using ProjectA.TeamA;
using ProjectA.TeamB;

class Program
{
    public static void Main()
    {
        // Ambiguous reference error
        ClassA.print();
        ClassA.print();
    }

}

namespace ProjectA
{
    namespace TeamA
    {
        class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("Team A Print Method");
            }
        }
}

}

namespace ProjectA
{
    namespace TeamB
    {
        class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("Team B Print Method");
            }
        }
}

}
