// Bài 1: https://v1study.com/csharp-bai-tap-phan-thua-ke-va-da-hinh.html
class Persion
{
    public string name,sex,address,date;
    virtual public void inputInfo()
    {
        Console.Write("Nhap ten: ");
        name = Console.ReadLine();
        Console.Write("Nhap gioi tinh: ");
        sex = Console.ReadLine();
        Console.Write("Nhap dia chi: ");
        address = Console.ReadLine();
        Console.Write("Nhap ngay sinh: ");
        date = Console.ReadLine();
    }
    virtual public void showInfo()
    {
        Console.Write($"Ten: {name}; Gioi tinh: {sex}; Ngay sinh: {date}; Dia chi: {address}");
    }
}
class Student : Persion
{
    public string msv,email;
    public double dtb;
    public static List<Student> DS_HB = new List<Student>();
    public override void inputInfo()
    {
        base.inputInfo();
        Console.Write("Nhap MSV: ");
        msv = Console.ReadLine();
        Console.Write("Nhap Email: ");
        email = Console.ReadLine();
        Console.Write("nhap Diem TB: ");
        dtb = double.Parse(Console.ReadLine());
    }
    public override void showInfo()
    {
        base.showInfo();
        Console.WriteLine($"; MSV: {msv}; Email: {email}; Diem TB = {dtb}");
    }
    public void XetHB()
    {
        if(dtb >= 8) DS_HB.Add(this);
    }
}
class StudentTest
{
    static void Main()
    {
        Console.WriteLine(@"
        Bam 1: Nhap vao n sv
        Bam 2 : Hien thi thong tin tat ca sv
        Bam 3 : Hien thi sv co dtb cao nhat va sv co dtb thap nhat
        Bam 4 : Tim kiem sv bang ma
        Bam 5 : Hien thi sv theo thu tu ten theo bang chu cai a-z
        Bam 6 : Hien thi sv dat hoc bong va sap xep theo thu tu diem giam dan
        Bam 7: Dung");
        List<Student> DS_Student = new List<Student>();
        while (true)
        {
            Console.Write("Nhap chuc nang: ");
            int cn = int.Parse(Console.ReadLine());
            switch(cn)
            {
                case 1 :
                    Console.Write("Nhap n sv = ");
                    int n = int.Parse(Console.ReadLine());
                    for(int i = 0; i <n ; i++)
                    {
                        Student hs = new Student();
                        hs.inputInfo();
                        Console.WriteLine();
                        DS_Student.Add(hs);
                    }
                    break;
                case 2 : 
                    foreach(var i in DS_Student)
                    {
                        i.showInfo();
                    }
                    break;
                case 3 :
                    foreach(var i in DS_Student)
                    {
                        if(i.dtb == DS_Student.Max(a => a.dtb)) 
                        {
                            Console.WriteLine("Sv co DTB max : ");
                            i.showInfo();
                        }
                        else if (i.dtb == DS_Student.Min(a => a.dtb))
                        {
                            Console.WriteLine("Sv co DTB min : ");
                            i.showInfo();
                        }
                    }
                    break;
                case 4 :
                    Console.Write("Nhap ma SV muon tim: ");
                    string ma = Console.ReadLine();
                    var tim = DS_Student.Find(a => a.msv == ma);
                    if(tim == null) Console.WriteLine($"Khong tim thay sv co MSV: {ma}");
                    else 
                        {Console.WriteLine("Sv da tim thay"); tim.showInfo();}
                    break;
                case 5 :
                    DS_Student.Sort((a,b)=> a.name.CompareTo(b.name));
                    Console.WriteLine("DS sau khi SX ten theo a-z");
                    foreach(var i in DS_Student)  i.showInfo();
                    break;
                case 6 : 
                    foreach(var i in DS_Student) i.XetHB();
                    Student.DS_HB.Sort((a,b) => b.dtb.CompareTo(a.dtb));
                    Console.WriteLine("DS sau khi sap xep theo thu tu diem giam dan");
                    foreach(var i in Student.DS_HB) i.showInfo();
                    break;
                case 7 : return;
            }
        }
    }
}
class Teacher : Persion
{
    public char lopday;
    public double luongh,sogioday,luong=0;
    public override void inputInfo()
    {
        base.inputInfo();
        Console.Write("Nhap Lop Day (G,H,I,K,L,M): ");
        lopday = Console.ReadKey().KeyChar;
        Console.Write("\nLuong moi gio: ");
        luongh = double.Parse(Console.ReadLine());
        Console.Write("So gio day: ");
        sogioday = double.Parse(Console.ReadLine());
    }
    public override void showInfo()
    {
        base.showInfo();
        Console.WriteLine($"; Lop Day: {lopday}; sogioday: {sogioday}; luongh: {luongh}; Luong nhan: {luong}");
    }
    public void Luong()
    {
        if (lopday == 'G' || lopday == 'H' || lopday == 'I' || lopday == 'K')
        {
            luong = luongh * sogioday;
        }
        else if (lopday == 'L' || lopday == 'M')
        {
            luong = luongh * sogioday + 200000;
        }
    }
}
class TeacherTest
{
    static void Main()
    {
        Console.WriteLine(@"
        Bam 1 : Nhap n giang vien
        Bam 2 : Hien thi thong tin giang vien
        Bam 3 : Hien thi thong tin giang vien co so gio day cao nhat
        Bam 4 : Hien thi thong tin giang vien co luong thuc nhan cao nhat
        Bam 5 : Dung");
        List<Teacher> DS_GV = new List<Teacher>();
        while (true)
        {
            Console.Write("Bam chon : ");
            int chon = int.Parse(Console.ReadLine());
            switch (chon)
            {
                case 1 :
                    Console.Write("Nhap so giang vien: ");
                    int n = int.Parse(Console.ReadLine());
                    for(int i = 0 ; i<n ; i++)
                    {
                        Teacher giangvien = new Teacher();
                        giangvien.inputInfo();
                        giangvien.Luong();
                        Console.WriteLine();
                        DS_GV.Add(giangvien);
                    }
                    break;
                case 2 :
                    Console.WriteLine("\nThong tin Giang vien da nhap:");
                    foreach(var i in DS_GV) i.showInfo();
                    break;
                case 3 :
                    Console.WriteLine("\nGiang Vien co so gio day cao nhat: ");
                    foreach(var i in DS_GV)
                    {
                        if(i.sogioday == DS_GV.Max(a => a.sogioday)) i.showInfo();
                    }
                    break;
                case 4 : 
                    Console.WriteLine("\nGiang Vien co so luong cao nhat: ");
                    foreach(var i in DS_GV)
                    {
                        if(i.luong == DS_GV.Max(a => a.luong)) i.showInfo();
                    }
                    break;
                case 5 : return;
            }

        }
    }
}