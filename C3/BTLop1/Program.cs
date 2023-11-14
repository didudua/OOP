using System;
using System.Collections.Generic;
public class NhaphocTKTH
{
    #region Thuộc tính
    public string Name;
    public string Ngaysinh;
    public string Gioitinh;
    public string ChNganh;
    #endregion

    #region Static
    public static List<NhaphocTKTH> TK = new List<NhaphocTKTH>();
    public static List<NhaphocTKTH> QTHTTT = new List<NhaphocTKTH>();
    public static List<NhaphocTKTH> THQL = new List<NhaphocTKTH>();
    public static int nam, nu = 0;
    #endregion

    #region Constructors
    public NhaphocTKTH()
    {
        Console.Write("Ten: ");
        Name = Console.ReadLine();
        Console.Write("Ngay Sinh (aa/bb/cccc): ");
        Ngaysinh = Console.ReadLine();
        Console.Write("Gioi Tinh: ");
        Gioitinh = Console.ReadLine();
        Console.Write("Chuyen Nganh (TK, QTHTTT, THQL): ");
        ChNganh = Console.ReadLine();
        Console.WriteLine();
        LocSV();
    }

    public void LocSV()
    {
        switch (ChNganh.ToUpper())
        {
            case "TK": TK.Add(this); break;
            case "QTHTTT": QTHTTT.Add(this); break;
            case "THQL": THQL.Add(this); break;
            default: break;
        }
    }
    public static void LocChuyenNganh()
    {
        Console.WriteLine("Thong ke theo chuyen nganh:\n");
        Console.WriteLine("Thong Ke co {0} SV\n",TK.Count);
        if (TK.Count != 0)
        {
            foreach( var i in TK)
            {
                ThongKe(TK);
                Console.WriteLine($"sinh vien: {i.Name}\ngioi tinh: {i.Gioitinh}\nngay sinh: {i.Ngaysinh}\n");
            }
            Console.WriteLine($"Co {nam} nam, {nu} nu");
            Console.WriteLine();
        }
        Console.WriteLine("Quan Tri HTTT co {0} SV\n",QTHTTT.Count);
        if (QTHTTT.Count != 0)
        {
            foreach( var i in QTHTTT)
            {
                ThongKe(QTHTTT);
                Console.WriteLine($"sinh vien: {i.Name}\ngioi tinh: {i.Gioitinh}\nngay sinh: {i.Ngaysinh}\n");
            }
            Console.WriteLine($"Co {nam} nam, {nu} nu");
            Console.WriteLine();
        }
        Console.WriteLine("THQL co {0} SV\n",THQL.Count);
        if (THQL.Count != 0)
        {
            foreach( var i in THQL)
            {
                ThongKe(THQL);
                Console.WriteLine($"sinh vien: {i.Name}\ngioi tinh: {i.Gioitinh}\nngay sinh: {i.Ngaysinh}\n");
            }
            Console.WriteLine($"Co {nam} nam, {nu} nu");
            Console.WriteLine();
        }
    }

    public static void ThongKe(List<NhaphocTKTH> X)
    {
        nam = 0;
        nu = 0;

        foreach (var sv in X)
        {
            if (sv.Gioitinh.ToUpper() == "NAM")
            {
                nam++;
            }
            else if (sv.Gioitinh.ToUpper() == "NU")
            {
                nu++;
            }
        }
    }
    #endregion

}

class Program
{
    static void Main()
    {
        NhaphocTKTH SV1 = new NhaphocTKTH();
        NhaphocTKTH SV2 = new NhaphocTKTH();
        NhaphocTKTH SV3 = new NhaphocTKTH();
        NhaphocTKTH SV4 = new NhaphocTKTH();

        NhaphocTKTH.LocChuyenNganh();
    }
}
