using System;

public class Student
{
    private int _id;
    private string _name;
    private int _passMark = 35;

    public int PassMark
    {
        get => this._passMark;
    }

    public string Name
    {
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new Exception("Name cannot be null or empty");
            }

            this._name = value;
        }

        get => string.IsNullOrEmpty(this._name) ? "No Name" : this._name;
    }

    public int Id
    {
        set
        {
            
            if (value <= 0)
            {
                throw new Exception("Student Id cannot be negative");
            }

            this._id = value;
        }

        get => this._id;
    }
    
}


public class Program
{
    public static void Main()
    {
        Student c1 = new Student();
        c1.Id = 101;
        c1.Name = "Brenda";
        Console.WriteLine("Student Id = {0} && Student Name = {1} && Student PassMark = {2}", c1.Id, c1.Name, c1.PassMark);

    }


}

