abstract class khachhang
{
    public string ten,cmnd;
    public int songaythue;
    abstract public void Xuat();
    public abstract double Gia();
}
class Standard : khachhang
{
    public override void Xuat()
    {
        Console.WriteLine($"Phong Standard: Khach: {ten}, cmnd: {cmnd}, So Ngay Thue: {songaythue}");
    }
    public override double Gia()
    {
        if(songaythue <=5 )
        {
            return songaythue* 500;
        }
        else return songaythue*400;
    }
}
class Luxury : khachhang
{
    public override void Xuat()
    {
        Console.WriteLine($"Phong VIP: Khach: {ten}, cmnd: {cmnd}, So Ngay Thue: {songaythue}, Loai Phong: Luxury ");
    }
    public override double Gia()
    {
        if(songaythue <=5 )
        {
            return songaythue* 1100;
        }
        else return songaythue*1000;
    }
}
class President : khachhang
{
    public override void Xuat()
    {
        Console.WriteLine($"Phong VIP: Khach: {ten}, cmnd: {cmnd}, So Ngay Thue: {songaythue}, Loai Phong: President");
    }
    public override double Gia()
    {
        if(songaythue <=5 )
        {
            return songaythue* 1300;
        }
        else return songaythue*1000;
    }
}
class program 
{
    static void Main()
    {
        List<khachhang> DS_KH = new List<khachhang>();
        DS_KH.Add( new Standard { ten = "Khach1", cmnd = "111111", songaythue = 3 });
        DS_KH.Add(new Standard { ten = "Khach2", cmnd = "222222", songaythue = 5 });
        DS_KH.Add(new Luxury { ten = "Khach3", cmnd = "333333", songaythue = 7 });
        DS_KH.Add(new President { ten = "Khach4", cmnd = "444444", songaythue = 4 });
        foreach(var i in DS_KH)
        {
            i.Xuat();
        }
        Console.WriteLine($"\nCo {DS_KH.Count} khach");
        double tongTienStandard = 0, tongTienVIP = 0,tongTienLuxury = 0;
        foreach (var kh in DS_KH)
        {
            if (kh is Standard)
            {
                tongTienStandard += kh.Gia();
            }
            else if (kh is Luxury || kh is President)
            {
                tongTienVIP += kh.Gia();
            }
        }
        foreach (var kh in DS_KH)
        {
            if (kh is Luxury)
            {
                tongTienLuxury += kh.Gia();
            }
        }
         Console.WriteLine($"\nTong so tien cho thue phong Standard va VIP: {tongTienStandard+tongTienVIP}");
        
        
        Console.WriteLine();
        foreach (var kh in DS_KH)
        {
            if (kh is Standard)
            {
                kh.Xuat();
            }
        }
        Console.WriteLine($"\nTong so tien cho thue phong Luxury: {tongTienLuxury}");
    }
}
