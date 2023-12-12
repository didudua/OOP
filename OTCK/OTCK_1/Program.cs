using System.Text;

abstract public class DICHVU
{
    public string tenkhach, diemnhan, diemden;
    public double khoangcach, dongia,  giamgia;
    virtual public void Nhap()
    {
        Console.Write("Tên Khách: ");
        tenkhach = Console.ReadLine();
        Console.Write("Điểm Nhận: ");
        diemnhan = Console.ReadLine();
        Console.Write("Điểm Đến: ");
        diemden = Console.ReadLine();
        Console.Write("Khoảng Cách: ");
        khoangcach = double.Parse(Console.ReadLine());
        Console.Write("Đơn Giá: ");
        dongia = double.Parse(Console.ReadLine());
        Console.Write("Giảm Giá: ");
        giamgia  = double.Parse(Console.ReadLine());
    }
    virtual public void phidichvu(){}
}
class xemay : DICHVU
{
    public double pdv;
    public override void Nhap()
    {
        Console.WriteLine("\nNhập Xe máy: ");
        base.Nhap();
    }
     public override void phidichvu()
    {
        pdv = dongia*khoangcach - giamgia;
        Console.WriteLine($"Phí dịch vụ = {pdv}");
    }
}
class oto : DICHVU
{
    public double pdv,hesoloaixe,loaixe;
    public override void Nhap()
    {
        Console.WriteLine("\nNhập xe ôtô: ");
        base.Nhap();
        Console.Write("Loại xe (4,7): ");
        loaixe = double.Parse(Console.ReadLine());
        switch (loaixe)
        {
            case 4 : hesoloaixe = 1; break;
            case 7 : hesoloaixe = 2; break;
        }
        Console.WriteLine($"Hệ số loại xe: {hesoloaixe}");
    }
    public override void phidichvu()
    {
        pdv = (dongia*khoangcach)*hesoloaixe - giamgia;
        Console.WriteLine($"Phí dịch vụ = {pdv}");
    }
}
class giaohang : DICHVU
{
    public double pdv,giasp;
    public override void Nhap()
    {
        Console.WriteLine("\nNhập giao hàng: ");
        base.Nhap();
        Console.Write("Giá Sản Phẩm: ");
        giasp = double.Parse(Console.ReadLine());
    }
    public override void phidichvu()
    {
        pdv = (dongia*khoangcach) + giasp - giamgia;
        Console.WriteLine($"Phí dịch vụ = {pdv}");
    }
}
class program
{
    static void Main()
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;
        Console.WriteLine(@"
            ---------MENU---------
            Bấm 0: Dừng
            Bấm 1: xe máy
            Bấm 2: ô tô
            Bấm 3: giao hàng");
        while (true)
        {
            Console.Write("\nNhập chức năng: ");
            int cn = int.Parse(Console.ReadLine());
            switch(cn)
            {
                case 0 : return;
                case 1 : 
                    xemay a = new xemay();
                    a.Nhap();
                    a.phidichvu();
                    break;
                case 2 : 
                    oto b = new oto();
                    b.Nhap();
                    b.phidichvu();
                    break;
                case 3 : 
                    giaohang c = new giaohang();
                    c.Nhap();
                    c.phidichvu();
                    break;
            }
        }
    }
}
