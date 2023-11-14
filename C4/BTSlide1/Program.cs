using System;

public class Phanso
{
    public int tuso;
    public int mauso;

    public Phanso()
    {
        Console.Write("Tu so: ");
        this.tuso = int.Parse(Console.ReadLine());
        Console.Write("Mau so: ");
        this.mauso = int.Parse(Console.ReadLine());
    }
    public static bool KT(int b,int d)
    {
        return (b == 0 || d == 0);
    }
    public static double Cong(int a, int b, int c, int d)
    {
        return (double)(a * d + c * b) / (b * d);
    }

    public static double Tru(int a, int b, int c, int d)
    {
        return (double)(a * d - c * b) / (b * d);
    }

    public static double Nhan(int a, int b, int c, int d)
    {
        return (double)(a * c) / (b * d);
    }

    public static double Chia(int a, int b, int c, int d)
    {
        return (double)(a * d) / (b * c);
    }

    public static void Xuat(double kq)
    {
        Console.WriteLine("Ket qua: {0}", kq);
    }
}

class Program
{
    static void Main()
    {
        double cong, tru, nhan, chia;
        Phanso A = new Phanso();
        Phanso B = new Phanso();
        if (!Phanso.KT(A.mauso, B.mauso))
        {
            cong = Phanso.Cong(A.tuso, A.mauso, B.tuso, B.mauso);
            tru = Phanso.Tru(A.tuso, A.mauso, B.tuso, B.mauso);
            nhan = Phanso.Nhan(A.tuso, A.mauso, B.tuso, B.mauso);
            chia = Phanso.Chia(A.tuso, A.mauso, B.tuso, B.mauso);
            Console.WriteLine("KET QUA:");
            Console.WriteLine($"Cong = {cong}\nTru = {tru}\nNhan = {nhan}\nChia = {chia}");
        }
        else Console.WriteLine("Loi !!!");
    }
}
