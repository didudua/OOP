using System;
public class Info
{
    public string ID,Hoten,Group;
    public static int soSV = 0;
    public DiemTP a;
    public Info()
    {
        soSV++;
        Console.Write("Nhap Ma SV: ");
        ID = Console.ReadLine();
        Console.Write("Nhap Ho va Ten: ");
        Hoten = Console.ReadLine();
        Console.Write("Nhap Lop: ");
        Group = Console.ReadLine();
        a = new DiemTP();
    }
    public void Xuat()
    {
        Console.WriteLine($"MSV: {ID}, Ho Ten: {Hoten}, Lop: {Group}, DiemTP: {a.DiemTB()}");
    }
}
public class DiemTP
{
    public double TP1,TP2,TP3;
    public DiemTP()
    {
        Console.Write("Nhap Diem TP1: ");
        TP1 = int.Parse(Console.ReadLine());
        Console.Write("Nhap Diem TP2: ");
        TP2 = int.Parse(Console.ReadLine());
        Console.Write("Nhap Diem TP3: ");
        TP3 = int.Parse(Console.ReadLine());
        Console.WriteLine();
    }
    public double DiemTB()
    {
        return (TP1*0.1 + TP2*0.3 + TP3*0.6);
    }
}
class program
{
    static void Main()
    {
        Info A = new Info();
        Info B = new Info();
        Info C = new Info();
        Console.WriteLine("Lop OOP co {0} SV",Info.soSV);
        A.Xuat();
        B.Xuat();
        C.Xuat();
    }
}
