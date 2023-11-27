public abstract class Hinhhoc
{
    public abstract void Chuvi();
    public abstract void Dientich();
} 
public class Hinhchunhat: Hinhhoc
{
    private double dai, rong;
    public void Nhap()
    {
        Console.WriteLine("---Hinh Chu Nhat--- ");
        Console.Write("Nhap chieu dai: ");
        dai = double.Parse(Console.ReadLine());
        Console.Write("Nhap chieu rong: ");
        rong = double.Parse(Console.ReadLine());
    }
    public override void Chuvi()
    {
        Console.WriteLine($"Chu vi hinh chu nhat = {(dai + rong) * 2}");
    }
    public override void Dientich()
    {
        Console.WriteLine($"Dien tich hinh chu nhat = {dai*rong}");
    }
}
public class Hinhtron: Hinhhoc
{
    private double r, pi = 3.14;
    public void Nhap()
    {
        Console.WriteLine("---Hinh Tron--- ");
        Console.Write("Nhap ban kinh hinh tron: ");
        r = double.Parse(Console.ReadLine());
    }
    public override void Chuvi()
    {
        Console.WriteLine($"Chu vi hinh tron = {2*pi*r}");
    }
    public override void Dientich()
    {
        Console.WriteLine($"Dien tich hinh tron = {pi*r*r}");
    }
}
public class Hinhtamgiac: Hinhhoc
{
    private double a,b,c,P,S;
    public void Nhap()
    {
        Console.WriteLine("---Hinh Tam Giac--- ");
        Console.Write("Nhap a: ");
        a = double.Parse(Console.ReadLine());
        Console.Write("Nhap b: ");
        b = double.Parse(Console.ReadLine());
        Console.Write("Nhap c: ");
        c = double.Parse(Console.ReadLine());
    }
    public override void Chuvi()
    {
        if (a+b>c & b+c>a & a+c>b)
        {
            Console.WriteLine($"Chu vi hinh tam giac = {a+b+c}");
        }
        else
        {
            Console.WriteLine("Thong tin khong hop le !!!");
        }
    }
    public override void Dientich()
    {
        P=(a+b+c)/2;
        S=Math.Sqrt(P*(P-a)*(P-b)*(P-c)); 
        if (a+b>c & b+c>a & a+c>b)
        {  
            Console.WriteLine($"Dien tich hinh tam giac = {S}");
        }
        else
        {
            Console.WriteLine("Thong tin khong hop le !!!");
        }
    }
}
public class Hinhvuong: Hinhhoc
{
    private double canh;
    public void Nhap()
    {
        Console.WriteLine("---Hinh Vuong--- ");
        Console.Write("Nhap canh cua hinh vuong: ");
        canh=double.Parse(Console.ReadLine());
    }
    public override void Chuvi()
    {
        Console.WriteLine($"Chu vi hinh vuong = {canh*4} ");
    }
    public override void Dientich()
    {
        Console.WriteLine($"Dien tich hinh vuong = {canh * canh}");
    }
}
class Program
{
    static void Main ()
    {
        Hinhchunhat a = new Hinhchunhat();
        a.Nhap();
        a.Chuvi();
        a.Dientich();
        Hinhtron b = new Hinhtron();
        b.Nhap();
        b.Chuvi();
        b.Dientich();
        Hinhtamgiac c = new Hinhtamgiac();
        c.Nhap();
        c.Chuvi();
        c.Dientich();
        Hinhvuong d = new Hinhvuong();
        d.Nhap();
        d.Chuvi();
        d.Dientich();
    }
}
