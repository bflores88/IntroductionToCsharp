using System;

public class ParentClass
{
    public ParentClass()
    {
        Console.WriteLine("ParentClass Constructor called");
    }
    
    // overloading constructor
    public ParentClass(string Message)
    {
        Console.WriteLine(Message);
    }
}

public class ChildClass : ParentClass
{
    // use base to control which constructor is called
    public ChildClass(): base("Derived class controller Parent class")
    {
        Console.WriteLine("ChildClass constructor called");
    }
}
public class Program
{
    public static void Main()
    {
       
        ChildClass CC = new ChildClass();
    }

}

