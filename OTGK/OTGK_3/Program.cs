using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

public class Shop
{
    private string MaSP, TenSP, PhanLoai;
    private int TonKho, GiaBan;

    public string GetMaSP()
    {
        return MaSP;
    }
    public string GetTenSP()
    {
        return TenSP;
    }
    public string GetPhanLoai()
    {
        return PhanLoai;
    }
    public int GetTonKho()
    {
        return TonKho;
    }
    public int GetGiaBan()
    {
        return GiaBan;
    }
    public void SetTonKho(int tonKho)
    {
        TonKho = tonKho;
    }
    public void SetGiaBan(int giaBan)
    {
        GiaBan = giaBan;
    }
    public Shop(string MaSP, string TenSP, int TonKho, string PhanLoai, int GiaBan)
    {
        this.MaSP = MaSP;
        this.TenSP = TenSP;
        this.GiaBan = GiaBan;
        this.PhanLoai = PhanLoai;
        this.TonKho = TonKho;
    }
}

public class QuanLyShop
{
    private List<Shop> QL;

    public QuanLyShop()
    {
        QL = new List<Shop>();
        string[] input = File.ReadAllLines("file.txt");
        foreach (var dong in input)
        {
            var thongtin = dong.Split(';');
            if (thongtin.Length == 5)
                QL.Add(new Shop(thongtin[0].Trim(), thongtin[1].Trim(), int.Parse(thongtin[2].Trim()), thongtin[3].Trim(), int.Parse(thongtin[4].Trim())));
        }
    }

    public void CapNhap()
    {
        Console.Write("Nhập MaSP muốn Cập Nhật: ");
        string ma = Console.ReadLine();
        foreach (var sp in QL)
        {
            if (sp.GetMaSP() == ma)
            {
                Console.Write("Nhập Số Lượng cập nhật: ");
                sp.SetTonKho(int.Parse(Console.ReadLine()));
                Console.Write("Nhập Giá cập nhật: ");
                sp.SetGiaBan(int.Parse(Console.ReadLine()));
            }
        }
        Console.WriteLine("Danh sách sản phẩm sau khi thay đổi: ");
        foreach (var sp in QL)
            Console.WriteLine($"{sp.GetMaSP()}; {sp.GetTenSP()}; {sp.GetTonKho()}; {sp.GetPhanLoai()}; {sp.GetGiaBan()}");
    }

    public void ThongKe()
    {
        int dem = 0;
        Console.WriteLine("Sản phẩm có lượng tồn kho thấp: ");
        foreach (var sp in QL)
        {
            if (sp.GetTonKho() <= 10)
            {
                dem++;
                Console.WriteLine($"{sp.GetMaSP()}; {sp.GetTenSP()}; {sp.GetTonKho()}; {sp.GetPhanLoai()}; {sp.GetGiaBan()}");
            }
        }
        Console.WriteLine("Tổng = {0}", dem);
    }

    public void Mua()
    {
        int tong = 0;
        while (true)
        {
            Console.Write("Nhập MaSP muốn mua: ");
            string ma = Console.ReadLine();
            var sp = QL.Find(Sp => Sp.GetMaSP() == ma);
            if (sp == null)
                Console.WriteLine("Không hợp lệ");
            else
            {
                Console.Write("Nhập Số Lượng muốn mua: ");
                int sl = int.Parse(Console.ReadLine());
                if (sl > sp.GetTonKho())
                    Console.WriteLine("Không hợp lệ");
                else
                    tong += sl * sp.GetGiaBan();
            }
            Console.Write("Tiếp tục? (Nhập 'k' để kết thúc): ");
            string kt = Console.ReadLine();
            if (kt == "k") break;
        }
        Console.WriteLine("Tổng Hóa Đơn Phải Trả: {0}", tong);
    }
}

class Program
{
    static void Main()
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;
        Console.WriteLine(@"
        -----MENU-----
        Nhấn 1: Cập nhật
        Nhấn 2: Thống kê
        Nhấn 3: Mua hàng
        Nhấn 0: Thoát");
        QuanLyShop QLS = new QuanLyShop();
        while (true)
        {
            Console.Write("Nhập chức năng: ");
            int cn = int.Parse(Console.ReadLine());
            switch (cn)
            {
                case 1: QLS.CapNhap(); break;
                case 2: QLS.ThongKe(); break;
                case 3: QLS.Mua(); break;
                case 0: return;
            }
        }
    }
}