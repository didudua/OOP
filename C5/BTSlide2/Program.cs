public class People
{
    public string ID,HoTen,Diachi;
    public int Tuoi;
    public People()
    {
        Console.Write("nhap ID: ");
        ID = Console.ReadLine();
        Console.Write("nhap HoTen: ");
        HoTen =  Console.ReadLine();
        Console.Write("nhap tuoi: ");
        Tuoi = int.Parse(Console.ReadLine());
        Console.Write("nhap Diachi: ");
        Diachi = Console.ReadLine();
    }
    public void Xuat()
    {
        Console.WriteLine($"ID: {ID}, Name: {HoTen}, Tuoi: {Tuoi}, Diachi: {Diachi}");
    }
}
public class Students : People
{
    public string [] DTP = new string [3];
    public float DTB;
    public string XepLoai;
    public Students()
    {
        Console.WriteLine("Nhap DTP: ");
        DTP[0] = Console.ReadLine();
        DTP[1] = Console.ReadLine();
        DTP[2] = Console.ReadLine();
        DTB = (float.Parse(DTP[0]) + float.Parse(DTP[1]) + float.Parse(DTP[2])) / 3;
        if (DTB >= 8)
        {
            XepLoai = "Gioi";
        }
        else if (DTB >= 6.5)
        {
            XepLoai = "Kha";
        }
        else if (DTB >= 5)
        {
            XepLoai = "Trung binh";
        }
        else
        {
            XepLoai = "Yeu";
        }
        
    }
    public new void Xuat()
    {
        base.Xuat();
        Console.WriteLine($"DTB: {DTB}, XepLoai: {XepLoai}");
    }
}
public class Lecture : People
{
    public int Kinhnghiem;
    public string Hocvi,Chucvu;
    public Lecture()
    {
        Console.Write("Nhap kinh nghiem: ");
        Kinhnghiem = int.Parse(Console.ReadLine());
        Console.Write("Nhap hoc vi: ");
        Hocvi = Console.ReadLine();
        Console.Write("Nhap chuc vu: ");
        Chucvu = Console.ReadLine();
    }
    public void Xuat()
    {
        base.Xuat();
        Console.Write($", Kinh Nghiem: {Kinhnghiem}, Chucvu: {Chucvu}, Hocvi: {Hocvi}");
    }
    
}
class program 
{
    static void Main()
    {
        People A = new People();
        A.Xuat();
        Students B = new Students(); // khi gọi thì nó sẽ chạy lớp cha trước, xong tới lớp con
        B.Xuat();
        List<Lecture> DS = new List<Lecture>();
        Lecture a = new Lecture();
        Lecture b = new Lecture();
        Lecture c = new Lecture();
        DS.Add(a);
        DS.Add(b);
        DS.Add(c);
        DS.Sort((x,y) => x.Kinhnghiem.CompareTo(y.Kinhnghiem));
        foreach(var i in DS)
        {
            i.Xuat();
        }
    }
}