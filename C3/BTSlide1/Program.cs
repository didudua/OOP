using System;

public class Sach
{
    private string Tensach ;
    private string Tacgia ;
    private int NamXB ;
    private int Soluong ;

    public Sach(string tensach, string tacgia, int namXB, int soluong)
    {
        Tensach = tensach;
        Tacgia = tacgia;
        NamXB = namXB;
        Soluong = soluong;
    }
    public Sach()
    {
        Nhap();
    }
    ~Sach()
    {
        Console.WriteLine("Sach da huy");
    }

    public void Nhap()
    {
        Console.WriteLine("Nhap Sach: ");
        Console.Write("Ten sach: ");
        Tensach = Console.ReadLine();
        Console.Write("Tac gia: ");
        Tacgia = Console.ReadLine();
        Console.Write("Nam XB: ");
        NamXB = int.Parse(Console.ReadLine());
        Console.Write("So luong: ");
        Soluong = int.Parse(Console.ReadLine());
    }

    public void Xuat()
    {
        Console.WriteLine("Thong tin sach:");
        Console.WriteLine("Ten sach: {0}", Tensach);
        Console.WriteLine("Tac gia: {0}", Tacgia);
        Console.WriteLine("Nam XB: {0}", NamXB);
        Console.WriteLine("So luong: {0}", Soluong);
    }
}

class Program
{
    static void Main()
    {
        Sach sach1 = new Sach("Sach 1", "Tac gia 1", 2023, 50);
        Console.WriteLine("");
        sach1.Xuat();
        Console.WriteLine("");
        Sach sach2 = new Sach();
        Console.WriteLine("");
        sach2.Xuat();
    }
}
