using System;
using System.Collections.Generic;
public class Meo
{
    #region thuộc tính
    private string Ten ;
    private string Giong ;
    private string Gioitinh ;
    private int Tuoi ;
    #endregion
    #region Constructor
    public Meo(string ten, string giong, string gioitinh, int tuoi)
    {
        Ten = ten;
        Giong = giong;
        Gioitinh = gioitinh;
        Tuoi = tuoi; 
    }
    public static int dem = 0;
    public Meo()
    {
        dem++;
        Console.Write("Nhap ten: ");
        Ten = Console.ReadLine();
        Console.Write("Nhap giong: ");
        Giong = Console.ReadLine();
        Console.Write("Nhap gioitinh: ");
        Gioitinh = Console.ReadLine();
        Console.Write("Nhap tuoi: ");
        Tuoi = int.Parse(Console.ReadLine());
        Console.WriteLine();
    }
    ~Meo()
    {
        Console.WriteLine("Meo da huy!");
    }
    public void Xuat()
    {
        Console.WriteLine("Ten: {0}, Giong: {1}, Gioitinh: {2}, Tuoi: {3}",Ten,Giong,Gioitinh,Tuoi);
    }
    #endregion
}
class Program
{
    static void Main()
    {
        Console.WriteLine("Nhap Meo");
        Meo meo = new Meo();
        Meo meo1 = new Meo();
        Meo meo2 = new Meo();
        Meo meo3 = new Meo();
        Console.WriteLine("Ban da nhap: ");
        meo.Xuat();
        meo1.Xuat();
        meo2.Xuat();
        meo3.Xuat();
        Console.WriteLine("Ban da nhap {0} con meo",Meo.dem);
    }
}
