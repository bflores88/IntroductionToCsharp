using System;

public class Employee
{
    public string FirstName;
    public string LastName;

    public void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName);
    }
}

public class PartTimeEmployee : Employee
{
    // the method below hides the PrintFullName method in the parent class
    public new void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName + " - Contractor");
    }
}

public class FullTimeEmployee : Employee
{
    
}
public class Program
{
    public static void Main()
    {
       FullTimeEmployee FTE = new FullTimeEmployee();
       FTE.FirstName = "Full Time";
       FTE.LastName = "Employee";
       FTE.PrintFullName();
       
       PartTimeEmployee PTE = new PartTimeEmployee();
       PTE.FirstName = "Part Time";
       PTE.LastName = "Employee";
       ((Employee) PTE).PrintFullName();

    }

}

