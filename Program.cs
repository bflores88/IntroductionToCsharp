using System;

class Circle
{
    static float _PI = 3.141F;
    private int _Radius;
    

    public Circle(int Radius)
    {
        this._Radius = Radius;
    }

    public float CalculateArea()
    {
        return Circle._PI * this._Radius * this._Radius;
    }
    
}

class Program
{
    public static void Main()
    {
        Circle C1 = new Circle(5);
        float Area1 = C1.CalculateArea();
        Console.WriteLine("Area = {0}", Area1);
        
        Circle C2 = new Circle(6);
        float Area2 = C2.CalculateArea();
        Console.WriteLine("Area = {0}", Area2);
    }

}

