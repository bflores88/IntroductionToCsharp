using System;
using PATA = ProjectA.TeamA;
using PATB = ProjectA.TeamB;
class Program
{
    public static void Main()
    {
        // alias directives can be used to resolve ambiguity between names (other than fully qualified name)
        PATA.ClassA.Print();
        PATB.ClassA.Print();
        
        // alias directives are also helpful when the namespace names are very long
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
