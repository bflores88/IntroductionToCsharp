using System;

class Customer
{
    // fields
    private string _firstName;
    private string _lastName;

    // constructor
    public Customer() 
        : this("No firstName Provided", "No lastName Provided")
    {
        
    }

    public Customer(string firstName, string lastName)
    {
        this._firstName = firstName;
        this._lastName = lastName;
    }

    // method
    public void printFullName()
    {
        Console.WriteLine("Full Name = {0}", this._firstName + " " + this._lastName);
    }
    
    // destructor
    ~Customer()
    {
        // clean up code
    }
}
class Program
{
    public static void Main()
    {
        Customer C1 = new Customer();
        C1.printFullName();
    }

}

