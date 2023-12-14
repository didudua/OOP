// Bài 3: https://v1study.com/csharp-bai-tap-phan-thua-ke-va-da-hinh.html
class KeSach
{
    public string mucsach;
    public int stt;
    public static List<List<Sach>> ListKeSach = new List<List<Sach>>();
}
class Sach : KeSach
{
    public string maSach, tenTG;
    public int NXB, Gia;
    public void Nhap()
    {
        Console.Write("Nhap stt ke sach : ");
        stt = int.Parse(Console.ReadLine());
        Console.Write("Nhap Muc Sach : ");
        mucsach = Console.ReadLine();
        Console.Write("Nhap Ma Sach : ");
        maSach = Console.ReadLine();
        Console.Write("Nhap Ten TG : ");
        tenTG = Console.ReadLine();
        Console.Write("Nhap NXB : ");
        NXB = int.Parse(Console.ReadLine());
        Console.Write("Nhap Gia : ");
        Gia = int.Parse(Console.ReadLine());
    }
    public void Xuat()
    {
        Console.WriteLine($"Ke: {stt}; Muc Sach : {mucsach}; Ma Sach: {maSach}; Tac Gia: {tenTG}; NXB: {NXB}; Gia: {Gia}");
    }
}
class QuanLyThuVien
{
    static void Main()
    {
        Console.WriteLine(@"
        Bam 1 : Them Sach
        Bam 2 : Xuat danh sach Sach
        Bam 3 : Xuat sach co gia cao nhat va gia thap nhat trong ke
        Bam 4 : Tim kiem cuon sach theo ma
        Bam 5 : Dung");

        List<Sach> ListSach1= new List<Sach>();
        List<Sach> ListSach2= new List<Sach>();
        List<Sach> ListSach3= new List<Sach>();

        Sach sach1 = new Sach{stt = 1,mucsach = "A",maSach = "1111", tenTG = "tac gia 1", NXB = 2000,Gia = 200000};
        Sach sach2 = new Sach{stt = 1,mucsach = "B",maSach = "1112", tenTG = "tac gia 2", NXB = 2001,Gia = 300000};
        Sach sach3 = new Sach{stt = 1,mucsach = "B",maSach = "1113", tenTG = "tac gia 3", NXB = 2002,Gia = 300000};
        Sach sach4 = new Sach{stt = 1,mucsach = "A",maSach = "1114", tenTG = "tac gia 4", NXB = 2003,Gia = 400000};
        Sach sach5 = new Sach{stt = 1,mucsach = "C",maSach = "1115", tenTG = "tac gia 5", NXB = 2004,Gia = 500000};
        Sach sach6 = new Sach{stt = 2,mucsach = "A",maSach = "1116", tenTG = "tac gia 6", NXB = 2005,Gia = 300000};
        Sach sach7 = new Sach{stt = 2,mucsach = "B",maSach = "1117", tenTG = "tac gia 7", NXB = 2006,Gia = 100000};
        Sach sach8 = new Sach{stt = 2,mucsach = "A",maSach = "1118", tenTG = "tac gia 8", NXB = 2007,Gia = 600000};
        Sach sach9 = new Sach{stt = 3,mucsach = "A",maSach = "1119", tenTG = "tac gia 9", NXB = 2008,Gia = 100000};
        Sach sach10 = new Sach{stt = 3,mucsach = "B",maSach = "11110", tenTG = "tac gia 10", NXB = 2009,Gia = 200000};

        ListSach1.Add(sach1);
        ListSach1.Add(sach2);
        ListSach1.Add(sach3);
        ListSach1.Add(sach4);
        ListSach1.Add(sach5);

        ListSach2.Add(sach6);
        ListSach2.Add(sach7);
        ListSach2.Add(sach8);

        ListSach3.Add(sach9);
        ListSach3.Add(sach10);

        KeSach.ListKeSach.Add(ListSach1);
        KeSach.ListKeSach.Add(ListSach2);
        KeSach.ListKeSach.Add(ListSach3);
        while (true)
        {
            Console.Write("\nBam : ");
            int bam = int.Parse(Console.ReadLine());
            List<Sach> ListSach = new List<Sach>();
            switch(bam)
            {
                case 1 : 
                    
                    Sach sach = new Sach();
                    Console.WriteLine("\nNhap thong tin sach can them: ");
                    sach.Nhap();
                    ListSach.Add(sach);
                    KeSach.ListKeSach.Insert(sach.stt-1,ListSach);
                    break;
                case 2 :
                    foreach (var i in KeSach.ListKeSach)
                    {
                        i.Sort((x, y) => x.mucsach.CompareTo(y.mucsach));
                    }
                    Console.WriteLine("\nDanh Sach sach trong thu vien: ");
                    foreach (var i in KeSach.ListKeSach)
                    {
                        Console.WriteLine();
                        foreach(var j in i)
                        {
                            j.Xuat();
                        }
                    }
                    break;
                case 3 :
                    Console.Write("Nhap stt Ke Sach muon tim: ");
                    int Stt = int.Parse(Console.ReadLine());
                    if (Stt > KeSach.ListKeSach.Count) Console.WriteLine("Ke sach khong co sach");
                    else
                    {
                        foreach (var i in KeSach.ListKeSach[Stt-1])
                        {
                            if(i.Gia == KeSach.ListKeSach[Stt-1].Max(a => a.Gia))
                            {
                                Console.WriteLine("Sach co gia cao nhat");
                                i.Xuat();
                            }
                            else if(i.Gia == KeSach.ListKeSach[Stt-1].Min(a => a.Gia))
                            {
                                Console.WriteLine("Sach co gia thap nhat");
                                i.Xuat();
                            }
                        }
                    }
                    break;
                case 4 :
                    Console.Write("\nNhap ma sach muon tim: ");
                    string ma = Console.ReadLine();
                    bool tim = false;
                    foreach (var i in KeSach.ListKeSach)
                    {
                        foreach (var j in i)
                        {
                            if (ma == j.maSach) 
                            {
                                Console.WriteLine("Sach da tim thay: ");
                                j.Xuat();
                                tim = true;
                            }
                        }
                    }
                    if (!tim)
                    {
                        Console.WriteLine($"Khong tim thay sach voi ma {ma}");
                    }
                    break;
                case 5 : return; 
            }
        }
    }
}
