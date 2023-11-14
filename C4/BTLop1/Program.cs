using System;
public class SinhVien
{
    private string MaSV;
    private int SoTC;
    private int Giamtru;
    private int Hocphi;
    public string maSV
    {
        get { return MaSV ;}
        set { MaSV = value ;}
    }
    public int soTC
    {
        get { return SoTC ;}
        set { SoTC = value ;}
    }
        public int giamtru
    {
        get { return Giamtru ;}
        set { Giamtru = value ;}
    }
        public int hocphi
    {
        get { return soTC * 450000 - (giamtru/100)*(soTC*450000);}
    }
}
class Program
{
    static void Main()
    {
        SinhVien SV1 = new SinhVien();
        SV1.maSV = "12345";
        SV1.soTC = 3;
        SV1.giamtru = 3;
        // SV1.hocphi = SV1.soTC * 450000 - (SV1.giamtru/100)*(SV1.soTC*450000);
        Console.WriteLine($"Hoc phi cua Sv co ma SV : {SV1.maSV} la: {SV1.hocphi} ");
    }
}
