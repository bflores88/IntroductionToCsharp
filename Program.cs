using System;

public class Student
{
    private int _id;
    private string _name;
    private int _passMark = 35;

    public int GetPassMark()
    {
        return this._passMark;
    }
    public void SetName(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new Exception("Name cannot be null or empty");
        }

        this._name = name;
    }

    public string GetName()
    {
        return string.IsNullOrEmpty(this._name) ? "No Name" : this._name;
    }

    public void SetId(int Id)
    {
        if (Id <= 0)
        {
            throw new Exception("Student Id cannot be negative");
        }

        this._id = Id;
    }

    public int GetId()
    {
        return this._id;
    }
}


public class Program
{
    public static void Main()
    {
        Student c1 = new Student();
        c1.SetId(10);
        c1.SetName("Mia");
        Console.WriteLine("Student Id = {0} && Student Name = {1} && Student PassMark = {2}", c1.GetId(), c1.GetName(), c1.GetPassMark());
        
        
        
    }


}

