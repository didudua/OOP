public class Basic 
{
    public string ID;
    public double Floor,Price,Area;
    virtual public void Gia()
    {
        Price = 1000*Area;
    }
    virtual public void Xuat()
    {
        Console.WriteLine($"BASIC: ID: {ID}, Dien Tich: {Area}, Tang: {Floor}, Gia: {Price}");
    }
}
class Condo : Basic
{
    public string view;
    public double heso;
    public override void Gia()
    {
        if(view == "Bien") heso = 1.4;
        else if(view == "Ho Boi") heso = 1.1;
        else if(view == "Thanh Pho") heso = 1.2;
        else heso = 1.0;
        Price = 2000*Area*heso;
    }
    public override void Xuat()
    {
        Console.WriteLine($"CONDO: ID: {ID}, Dien Tich: {Area}, Tang: {Floor},View: {view}, Heso: {heso} Gia: {Price}");
    }
}
class program
{
    static void Main()
    {
        List<Basic> DS_CH = new List<Basic>();
        Basic canho4 = new Basic { ID = "111111", Area = 15,Floor = 3};
        canho4.Gia();
        canho4.Xuat();
        Condo canho1 = new Condo { ID = "22222", Area = 20,Floor = 5, view = "Ho Boi"};
        canho1.Gia();
        canho1.Xuat();
        Condo canho2 = new Condo { ID = "333333", Area = 15,Floor = 5, view = "Thanh Pho"};
        canho2.Gia();
        canho2.Xuat();
        Condo canho3 = new Condo { ID = "444444", Area = 20,Floor = 3, view = "Bien"};
        canho3.Gia();
        canho3.Xuat();
        Basic canho5 = new Basic { ID = "55555", Area = 20,Floor = 2};
        canho5.Gia();
        canho5.Xuat();
        Basic canho6 = new Basic { ID = "66666", Area = 25,Floor = 2};
        canho6.Gia();
        canho6.Xuat();
        DS_CH.Add(canho1);
        DS_CH.Add(canho2);
        DS_CH.Add(canho3);
        DS_CH.Add(canho4);
        DS_CH.Add(canho5);

        Console.WriteLine($"\nTong Tien = {canho1.Price + canho2.Price + canho3.Price + canho4.Price + canho5.Price + canho6.Price}");
        foreach(var i in DS_CH)
        {
            if(i.Price == DS_CH.Max(x => x.Price)) i.Xuat();
        }
    }
}