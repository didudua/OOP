using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
public class Thangleo
{
    public string MaThang,LoaiThang;
    public int SoLuong;
    public float ChieuCao,GiaBan;
    public Thangleo(string MaThang,string LoaiThang, float ChieuCao,int SoLuong,float GiaBan)
    {
        this.MaThang = MaThang;
        this.LoaiThang = LoaiThang;
        this.ChieuCao = ChieuCao;
        this.SoLuong = SoLuong;
        this.GiaBan = GiaBan;
    }
    
}
public class DanhSachThang
{
    public List<Thangleo> DS_Thang = new List<Thangleo>();
    public void Nhap()
    {
        string [] input = File.ReadAllLines("file.txt");
        foreach (var dong in input)
        {
            var thongtin = dong.Split(',');
            if (thongtin.Length == 5) 
                DS_Thang.Add(new Thangleo(thongtin[0], thongtin[1], float.Parse(thongtin[2]), int.Parse(thongtin[3]), float.Parse(thongtin[4])));
        }
    }
    public void Xuat()
    {
        Console.WriteLine("Ma Thang; Loai Thang; Chieu Cao; So Luong; Gia Ban");
        foreach (var Thang in DS_Thang)
        {
            Console.WriteLine($"{Thang.MaThang}; {Thang.LoaiThang}; {Thang.ChieuCao}; {Thang.SoLuong}; {Thang.GiaBan}");
        }
    }
    public void Tim()
    {
        Console.Write("Nhập a: ");
        float a = float.Parse(Console.ReadLine());
        Console.Write("Nhập b: ");
        float b = float.Parse(Console.ReadLine());
        Console.WriteLine($"Chiều cao từ {a} đến {b}:");
        foreach (var Thang in DS_Thang)
        {
            if ((Thang.ChieuCao>= a && Thang.ChieuCao<= b) || (Thang.ChieuCao>=b && Thang.ChieuCao<= a))
            {
                Console.WriteLine($"{Thang.MaThang}; {Thang.LoaiThang}; {Thang.ChieuCao}; {Thang.SoLuong}; {Thang.GiaBan}");
            }
        }
    }
    public void SapXep()
    {
        Console.WriteLine("Da SX");
        DS_Thang.Sort( (x,y) => x.GiaBan.CompareTo( y.GiaBan));
        foreach(var Thang in DS_Thang)
        {
            Console.WriteLine($"{Thang.MaThang}; {Thang.LoaiThang}; {Thang.ChieuCao}; {Thang.SoLuong}; {Thang.GiaBan}");
        }
    }
    public void KiemTra()
    {
        Console.Write("Nhap Ma Thang muon KT: ");
        string ma = Console.ReadLine();
        foreach(var Thang in DS_Thang)
        {
            if (Thang.MaThang == ma)
            {
                Console.Write("Nhap SL can mua: ");
                int sl = int.Parse(Console.ReadLine());
                if (Thang.SoLuong >= sl) Console.WriteLine("OK");
                else Console.WriteLine($"CHỈ CÒN {Thang.SoLuong} THANG KHÔNG ĐỦ HÀNG");
            }
        }
    }
    public List<Thangleo> DS_SS = new List<Thangleo>();
    public void SoSanh()
    {
        Console.Write("Nhập Loại Thang: ");
        string loai = Console.ReadLine();
        Console.Write("Nhập Chiều Cao: ");
        float cao = float.Parse(Console.ReadLine());
        foreach(var Thang in DS_Thang)
        {
            if (Thang.LoaiThang == loai && Thang.ChieuCao == cao) DS_SS.Add(Thang);
        }
        if(DS_SS.Count != 0)
        {
            Console.WriteLine("THANG CÓ CẢ LOẠI VÀ CHIỀU CAO BẠN NHẬP");
            DS_SS.Sort( (x,y) => x.GiaBan.CompareTo( y.GiaBan));
            Console.Write("Thang có Giá Thấp Nhất: ");
            Console.WriteLine($"{DS_SS[0].MaThang}; {DS_SS[0].LoaiThang}; {DS_SS[0].ChieuCao}; {DS_SS[0].SoLuong}; {DS_SS[0].GiaBan}");
            Console.Write("Thang có Giá Cao Nhất: ");
            Console.WriteLine($"{DS_SS[^1].MaThang}; {DS_SS[^1].LoaiThang}; {DS_SS[^1].ChieuCao}; {DS_SS[^1].SoLuong}; {DS_SS[^1].GiaBan}");
        }
        else Console.WriteLine("KHÔNG CÓ THANG CÓ CẢ LOẠI VÀ CHIỀU CAO BẠN NHẬP");
    }
}
class program 
{
    static void Main()
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;
        DanhSachThang DS = new DanhSachThang();
        Console.WriteLine(@"
        --------- MENU ---------
        Bấm 1: Thêm mới danh sách
        Bấm 2: Xuất danh sách
        Bấm 3: Tìm sản phẩm
        Bấm 4: Sắp xếp
        Bấm 5: Kiểm tra
        Bấm 6: So sánh
        Bấm 0: Exit");
        while(true)
        {
            Console.Write("Chọn chức năng: ");
            int kt = int.Parse(Console.ReadLine());
            switch (kt)
            {
                case 0 : return;
                case 1 : DS.Nhap(); break;
                case 2 : DS.Xuat(); break;
                case 3 : DS.Tim(); break;
                case 4 : DS.SapXep(); break;
                case 5 : DS.KiemTra(); break;
                case 6 : DS.SoSanh(); break;
            }
        }
    }
}