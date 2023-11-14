using System;
public class Tamgiac
{
    public double a,b,c;
    public Tamgiac()
    {
        Console.Write("Canh a: ");
        a = double.Parse(Console.ReadLine());
        Console.Write("canh b: ");
        b = double.Parse(Console.ReadLine());
        Console.Write("canh c: ");
        c = double.Parse(Console.ReadLine());
    }
    public bool Vuong()
    {
        return (a*a + b*b == c*c || a*a + c*c == b*b || b*b + c*c == a*a);
    }
    public bool Can()
    {
        return (a == b || a == c || b == c);
    }
    public bool Dieu()
    {
        return ( a == b && a == c);
    }
    public void Kiemtra()
    {
        if (a+b>c && a+c>b && b+c>a) 
        {
            if (Vuong()) Console.WriteLine("Tam Giac Vuong");
            else if (Can()) Console.WriteLine("Tam Giac Can");
            else if (Vuong() && Can()) Console.WriteLine("Tam Giac Vuong Can");
            else if (Dieu()) Console.WriteLine("Tam Giac Dieu");
        } 
        else Console.WriteLine("Khong phai la tam giac !!!");
    }
}
class Program
{
    static void Main()
    {
        Tamgiac A = new Tamgiac();
        A.Kiemtra();
    }
}
