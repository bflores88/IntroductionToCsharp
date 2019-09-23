using System;

public struct Customer
{
    // private fields
    private int _id;
    private string _name;

    
    // public properties
    public string Name
    {
        get => this._name;
        set => this._name = value;
    }
    public int Id
    {
        get => this._id;
        set => this._id = value;
    }

    // constructor
    public Customer(int Id, string Name)
    {
        this._id = Id;
        this._name = Name;
    }
    
    // methods

    public void PrintDetails()
    {
        Console.WriteLine("Id = {0} && Name = {1}", this._id, this._name);
    }
}


public class Program
{
    public static void Main()
    {
        // using constructor
        Customer c1 = new Customer(101, "Mark");
        c1.PrintDetails();
        
        // using default constructor and public methods
        Customer c2 = new Customer();
        c2.Id = 102;
        c2.Name = "Ferdinand";
        c2.PrintDetails();
        
        // using object initializer syntax
        Customer c3 = new Customer
        {
            Id = 103,
            Name = "Robert"
        };
        c3.PrintDetails();
    }


}

