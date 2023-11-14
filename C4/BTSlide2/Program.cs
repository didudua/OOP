using System;
public class SoPhuc
{
    public double PhanThuc;
    public double PhanAo;
    public SoPhuc()
    {
        Console.Write("Phan Thuc: ");
        PhanThuc = double.Parse(Console.ReadLine());
        Console.Write("Phan Ao: ");
        PhanAo = double.Parse(Console.ReadLine());
    }
    public static void Cong(double a, double b, double c, double d)
    {
        Console.WriteLine("Cong = {0} + ( {1} )i",a+c,b+d); 
    }

    public static void Tru(double a, double b, double c, double d)
    {
        Console.WriteLine("Tru = {0} + ( {1} )i",a*c-b*d,a*d+b*c);
    }

    public static void Nhan(double a, double b, double c, double d)
    {
       Console.WriteLine("Nhan = {0} + ( {1} )i",a+c,b+d);
    }

    public static void Chia(double a, double b, double c, double d)
    {
       Console.WriteLine("Chia = {0} + ( {1} )i",(a*c+b*d)/(c*c+d*d),(b*c-a*d)/(c*c+d+d));
    }
}
class Program
{
    static void Main()
    {
        SoPhuc a = new SoPhuc();
        SoPhuc b = new SoPhuc();
        Console.WriteLine("Ket Qua");
        SoPhuc.Cong(a.PhanThuc,a.PhanAo,b.PhanThuc,b.PhanAo);
        SoPhuc.Tru(a.PhanThuc,a.PhanAo,b.PhanThuc,b.PhanAo);
        SoPhuc.Nhan(a.PhanThuc,a.PhanAo,b.PhanThuc,b.PhanAo);
        SoPhuc.Chia(a.PhanThuc,a.PhanAo,b.PhanThuc,b.PhanAo);
    }
}