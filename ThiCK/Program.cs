abstract class NGHESI
{
    public string TenNgheSi;
    public int SoNamLamViec,SoLuongTrinhDien;
    public double luong,kpi;
    public static double TongLuong;
    abstract public void Luong();
    virtual public void Xuat()
    {
        Console.Write($"{TenNgheSi}; So Nam Lam: {SoNamLamViec}; So Luong Trinh Dien: {SoLuongTrinhDien}");
    }
}
class IDOL : NGHESI
{
    public int SoLuongSuKien,SoLuongGameShow;
    public void KPI()
    {
        if(SoLuongTrinhDien>=15 && (SoLuongGameShow+SoLuongSuKien)>=10) kpi=0.3*(500*SoLuongTrinhDien + 200*SoLuongSuKien + 300*SoLuongGameShow);
        else kpi = 0;
    }
    public override void Luong()
    {
        this.KPI();
        luong = 1000 + 100*SoNamLamViec + 500*SoLuongTrinhDien + 200*SoLuongSuKien + 300*SoLuongGameShow + kpi;
        TongLuong += luong;
    }
    public override void Xuat()
    {
        base.Xuat();
        Console.WriteLine($"; So Luong Su Kien: {SoLuongSuKien}; SoLuong Game Show: {SoLuongGameShow}; KPI: {kpi} $; Luong: {luong} $");
    }
}
class DEBUT : NGHESI
{
    public int SoLuongSuKien;
    public void KPI()
    {
        if(SoLuongTrinhDien>=20 && SoLuongSuKien>=10) kpi=0.15*(300*SoLuongTrinhDien + 100*SoLuongSuKien );
        else kpi = 0;
    }
    public override void Luong()
    {
        this.KPI();
        luong = 500 + 50*SoNamLamViec + 300*SoLuongTrinhDien + 100*SoLuongSuKien + kpi;
        TongLuong += luong;
    }
    public override void Xuat()
    {
        base.Xuat();
        Console.WriteLine($"; So Luong Su Kien: {SoLuongSuKien}; KPI: {kpi} $; Luong: {luong} $");
    }
}
class INTERN : NGHESI
{
    public void KPI()
    {
        if(SoLuongTrinhDien>=20) kpi=0.1*(200*SoLuongTrinhDien);
        else kpi = 0;
    }
    public override void Luong()
    {
        this.KPI();
        luong = 300 + 50*SoNamLamViec + 200*SoLuongTrinhDien + kpi;
        TongLuong += luong;
    }
    public override void Xuat()
    {
        base.Xuat();
        Console.WriteLine($"; KPI: {kpi} $; Luong: {luong} $");
    }
}
class NGOISAOMOI
{
    static void Main()
    {
        List<NGHESI> ListNgheSi = new List<NGHESI>();
        IDOL idol1 = new IDOL{TenNgheSi = "Idol1",SoNamLamViec = 5,SoLuongTrinhDien=20,SoLuongSuKien = 10,SoLuongGameShow = 10};
        IDOL idol2 = new IDOL{TenNgheSi = "Idol2",SoNamLamViec = 2,SoLuongTrinhDien=15,SoLuongSuKien = 6,SoLuongGameShow = 5};
        IDOL idol3 = new IDOL{TenNgheSi = "Idol3",SoNamLamViec = 3,SoLuongTrinhDien=23,SoLuongSuKien = 9,SoLuongGameShow = 5};
        IDOL idol4 = new IDOL{TenNgheSi = "Idol4",SoNamLamViec = 7,SoLuongTrinhDien=20,SoLuongSuKien = 5,SoLuongGameShow = 6};
        IDOL idol5 = new IDOL{TenNgheSi = "Idol5",SoNamLamViec = 10,SoLuongTrinhDien=35,SoLuongSuKien = 15,SoLuongGameShow = 20};
        IDOL idol6 = new IDOL{TenNgheSi = "Idol6",SoNamLamViec = 5,SoLuongTrinhDien=16,SoLuongSuKien = 4,SoLuongGameShow = 5};
        IDOL idol7 = new IDOL{TenNgheSi = "Idol7",SoNamLamViec = 4,SoLuongTrinhDien=19,SoLuongSuKien = 8,SoLuongGameShow = 7};

        idol1.Luong();
        idol2.Luong();
        idol3.Luong();
        idol4.Luong();
        idol5.Luong();
        idol6.Luong();
        idol7.Luong();

        DEBUT debut1 = new DEBUT{TenNgheSi = "Debut1",SoNamLamViec = 2,SoLuongTrinhDien=8,SoLuongSuKien = 5};
        DEBUT debut2 = new DEBUT{TenNgheSi = "Debut2",SoNamLamViec = 7,SoLuongTrinhDien=20,SoLuongSuKien = 12};
        DEBUT debut3 = new DEBUT{TenNgheSi = "Debut3",SoNamLamViec = 5,SoLuongTrinhDien=9,SoLuongSuKien =7};

        debut1.Luong();
        debut2.Luong();
        debut3.Luong();

        INTERN intern1 = new INTERN{TenNgheSi = "Intern1",SoNamLamViec = 10,SoLuongTrinhDien=23};
        INTERN intern2 = new INTERN{TenNgheSi = "Intern2",SoNamLamViec = 5,SoLuongTrinhDien=10};
        INTERN intern3 = new INTERN{TenNgheSi = "Intern3",SoNamLamViec = 15,SoLuongTrinhDien=27};
        INTERN intern4 = new INTERN{TenNgheSi = "Intern4",SoNamLamViec = 8,SoLuongTrinhDien=15};
        INTERN intern5 = new INTERN{TenNgheSi = "Intern5",SoNamLamViec = 10,SoLuongTrinhDien=19};

        intern1.Luong();
        intern2.Luong();
        intern3.Luong();
        intern4.Luong();
        intern5.Luong();


        ListNgheSi.Add(idol1);
        ListNgheSi.Add(idol2);
        ListNgheSi.Add(idol3);
        ListNgheSi.Add(idol4);
        ListNgheSi.Add(idol5);
        ListNgheSi.Add(idol6);
        ListNgheSi.Add(idol7);

        ListNgheSi.Add(debut1);
        ListNgheSi.Add(debut2);
        ListNgheSi.Add(debut3);

        ListNgheSi.Add(intern1);
        ListNgheSi.Add(intern2);
        ListNgheSi.Add(intern3);
        ListNgheSi.Add(intern4);
        ListNgheSi.Add(intern5);
        // foreach (var i in ListNgheSi) i.Xuat();

        foreach (var i in ListNgheSi)
        {
            if(i.luong == ListNgheSi.Max(a => a.luong)) 
            {
                Console.WriteLine("\nNghe Si co Luong cao nhat");
                i.Xuat();
            }
            else if(i.luong == ListNgheSi.Min(a => a.luong))
            {
                Console.WriteLine("\nNghe Si Co Luong Thap Nhat");
                i.Xuat();
            }
        }

        Console.WriteLine($"\nTong Luong Phai Chi Tra : {NGHESI.TongLuong} $");
    }
}