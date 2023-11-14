using System;
public class Triangle
{
    #region Thuộc tính
    public int a;
    public int b;
    public int c;
    #endregion
    #region Constructors
    public Triangle(int A, int B, int C)
    {
        a=A;
        b=B;
        c=C; 
    }
    ~Triangle()
    {
        Console.WriteLine("Tam giac da huy !!");
    }
    public void Nhap()
    {
        Console.Write("Nhap a: ");
        a=int.Parse(Console.ReadLine());
        Console.Write("Nhap b: ");
        b=int.Parse(Console.ReadLine());
        Console.Write("Nhap c: ");
        c=int.Parse(Console.ReadLine());
    }
    public void Xuat()
    {
        Console.WriteLine($"a = {a}, b = {b}, c = {c}");
    }
    public void Tinh()
    {
        if (a + b > c && a + c > b && c + b > a) 
        {
            double p = a+b+c;
            double S2 = (p/2)*((p/2)-a)*((p/2)-b)*((p/2)-c);
            double S = Math.Sqrt(S2);
            Console.WriteLine($"Tam giac co chu vi {p}, Dien tich {S,2}");

        }
            else Console.WriteLine("Khong hop le !");
}
    #endregion
}
class Program
{
    #region MENU
    static void MENU()
    {
        Triangle canh = new Triangle(0,0,0);
        Console.WriteLine("Thu tu:\n1: Nhap canh \n2: Tinh\n3: Xuat\n0: out ");
        while (true)
        {
            Console.Write("Nhap Thu tu: ");
            int nhap = int.Parse(Console.ReadLine());
            switch (nhap)
            {
                case 0: return;
                case 1: canh.Nhap(); break;
                case 2: canh.Tinh(); break;
                case 3: canh.Xuat(); break;
                default: break;
            }
        }
    }
    #endregion
    static void Main()
    {
        MENU();
    }
}