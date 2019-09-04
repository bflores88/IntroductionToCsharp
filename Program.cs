using System;
using System.Text;

class Program
{
    public static void Main()
    {
        int Total = 0;
        int Product = 0;
       Calculate(10, 20, out Total, out Product);
       
       Console.WriteLine("Sum = {0} && Product = {1}", Total, Product);
    }
    public static void Calculate(int fN, int sN, out int Sum, out int Product)
    {
        Sum = fN + sN;
        Product = fN * sN;
    } 
}
