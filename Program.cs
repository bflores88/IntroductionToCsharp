using System;


interface I1
{
    void InterfaceMethod();
}

interface I2
{
    void InterfaceMethod();
}


public class Program: I1, I2
{
    // do not use access modifiers on implementation
    void I1.InterfaceMethod()
         {
             Console.WriteLine("I1 Interface Method");
         }
    
    void I2.InterfaceMethod()
    {
        Console.WriteLine("I2 Interface Method");
    }

    public static void Main()
    {
        // use type casting
        /* Program P = new Program();
        ((I1)P).InterfaceMethod();
        ((I2)P).InterfaceMethod();
        */
        
        // use interface reference variable to instantiate the class
        /* I1 i1 = new Program();
        I2 i2 = new Program();
        i1.InterfaceMethod();
        i2.InterfaceMethod();
        */ 
        
    }

}

