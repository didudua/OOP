using System;
public class HT
{
    public float bk, dk, dt;
    public static float pi = 3.14f;
    public HT(float bk, float dk)
    {
        this.bk = bk;
        this.dk = dk;
        this.dt = pi * bk * bk;
    }
    public void Xuat()
    {
        Console.Write($"bk = {bk}, dk = {dk}, dt = {dt}");
    }
}
public class HC : HT
{
    public float tt;
    public HC(float bk, float dk) : base(bk, dk)
    {
        this.dt = 4 * pi * bk * bk;
        this.tt = 4 / 3 * pi * bk * bk * bk;
    }
    public new void Xuat()
    {
        base.Xuat();
        Console.WriteLine($", tt = {tt}");
    }
}
class Program
{
    static void Main()
    {
        HT a = new HT(3, 6);
        a.Xuat();
        Console.WriteLine();
        HC b = new HC(3, 6);
        b.Xuat();
    }
}