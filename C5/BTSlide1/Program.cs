using System;
public class HT
{
    public float r, d, S;
    public static float pi = 3.14f;
    public HT(float r, float d)
    {
        this.r = r;
        this.d = d;
        this.S = pi * r * r;
    }
    public void Xuat()
    {
        Console.Write($"r = {r}, d = {d}, S = {S}");
    }
}
public class HC : HT
{
    public float V;
    public HC(float r, float d) : base(r, d)
    {
        this.S = 4 * pi * r * r;
        this.V = 4 / 3 * pi * r * r * r;
    }
    public new void Xuat()
    {
        base.Xuat();
        Console.WriteLine($", V = {V}");
    }
}
public class HTT : HT
{
    public float Cd,Sd,Sxq,Stp,Vhtt,h;
    public HTT(float r,float d, float h) : base(r,d)
    {
        this.Cd = 2 * pi * r;
        this.Sd = pi * r * r;
        this.Sxq = Cd*h;
        this.Stp = Sxq + Sd;
        this.Vhtt = Sd*h;
    }
    public new void Xuat()
    {
        base.Xuat();
        Console.WriteLine($",h ={h}, Cd = {Cd},Sd = {Sd}, Sxq = {Sxq}, Vhtt = {Vhtt}");
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
        HTT c = new HTT(3,6,8);
        c.Xuat();
    }
}