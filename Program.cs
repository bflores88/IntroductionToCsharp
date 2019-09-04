using System;
using ProjectA.TeamA;
class Program
{
    public static void Main()
    {
        // invoke via the using directive
       ClassA.Print();

       // invoke via the fully qualified name: namespace.class.method
       ProjectA.TeamB.ClassA.Print();
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
