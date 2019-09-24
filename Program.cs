using System;


interface ICustomer1
{
    // fields not allowed
    // int _id;
    
    
    // declarations only
    void Print1();
}

interface ICustomer2: ICustomer1
{
    void Print2();
}


public class Customer : ICustomer2
{
    // class must provide implementation for interface member

    public void Print1()
    {
        Console.WriteLine("Print1 Method");
    }
    
    public void Print2()
    {
        Console.WriteLine("Print2 Method");
    }
}



public class Program
{
    public static void Main()
    {
        ICustomer1 c1 = new Customer();
        c1.Print1();
    }

}

