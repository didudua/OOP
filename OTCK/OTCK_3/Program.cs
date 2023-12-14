// Bài 2: https://v1study.com/csharp-bai-tap-phan-thua-ke-va-da-hinh.html
abstract class Animal
{
    public string ten, moTa;
    public int tuoi;
    public abstract void xemThongTin();
    public abstract void tiengKeu();
}

class Cat : Animal
{
    public override void xemThongTin()
    {
        Console.WriteLine($"Cat: ten: {ten}; moTa: {moTa}; tuoi: {tuoi}");
    }
    public override void tiengKeu()
    {
        Console.Write("; Tieng Keu 'Meo Meo'");
    }
}
class Dog : Animal
{
    public override void xemThongTin()
    {
        Console.WriteLine($"Dog: ten: {ten}; moTa: {moTa}; tuoi: {tuoi}");
    }
    public override void tiengKeu()
    {
        Console.Write("; Tieng Keu 'Gau Gau'");
    }
}
class Tiger : Animal
{
    public override void xemThongTin()
    {
        Console.Write($"Tiger: ten: {ten}; moTa: {moTa}; tuoi: {tuoi}");
    }
    public override void tiengKeu()
    {
        Console.WriteLine("; Tieng Keu 'Grw Grw'");
    }
}
class Chuong
{
    public int MaChuong;
    public static List<Animal> DS_Animal = new List<Animal>();
    public static void themConVat(Animal a)
    {
        DS_Animal.Add(a);
        Console.WriteLine("\nDa Them !");
    }
    public static void xoaConVat(string ten)
    {
        for (int i = DS_Animal.Count - 1; i >= 0; i--)
        {
        if (DS_Animal[i].ten == ten)
        {
            DS_Animal.RemoveAt(i);
            break;
        }
        }
        Console.WriteLine("\nDa Xoa !");
    }
}
class Zoo
{
    public static List<Chuong> DS_Chuong = new List<Chuong>();
    public static void themChuong(Chuong a)
    {
        DS_Chuong.Add(a);
        Console.WriteLine("\nDa Them !");
    }
    public static void xoaChuong(int maChuong)
    {
        for (int i = DS_Chuong.Count - 1; i >= 0; i--)
        {
        if (DS_Chuong[i].MaChuong == maChuong)
        {
            DS_Chuong.RemoveAt(i);
            break;
        }
        }
        Console.WriteLine("\nDa Xoa !");
    }
}
class TestZoo
{
    static void Main()
    {
        Console.WriteLine(@"
        Chon 1 : Them Chuong
        Chon 2 : Xoa Chuong
        chon 3 : Them con vat
        chon 4 : Xoa con vat
        chon 5 : Xem tat ca con vat
        chon 6 : Dung");
        while (true)
        {
            Console.Write("\nChon : ");
            int chon = int.Parse(Console.ReadLine());
            switch (chon)
            {
                case 1 : 
                    Console.Write("\nNhap ma chuong muon them: ");
                    int ma = int.Parse(Console.ReadLine());
                    Chuong a = new Chuong();
                    a.MaChuong = ma;
                    Zoo.themChuong(a);
                    break;
                case 2 : 
                    Console.Write("\nNhap ma chuong muon xoa: ");
                    int max = int.Parse(Console.ReadLine());
                    Zoo.xoaChuong(max);
                    break;
                case 3 : 
                    Console.Write("\nNhap con vat muon them (Dog,Cat,Tiger): ");
                    string convat = Console.ReadLine();
                    switch(convat)
                    {
                        case "Dog": 
                            Dog dogx = new Dog();
                            Console.Write("Nhap ten: ");
                            dogx.ten = Console.ReadLine();
                            Console.Write("Nhap mo ta: ");
                            dogx.moTa = Console.ReadLine();
                            Console.Write("Nhap tuoi: ");
                            dogx.tuoi = int.Parse(Console.ReadLine());
                            Chuong.DS_Animal.Add(dogx);
                            break;
                        case "Cat": 
                            Cat catx = new Cat();
                            Console.Write("Nhap ten: ");
                            catx.ten = Console.ReadLine();
                            Console.Write("Nhap mo ta: ");
                            catx.moTa = Console.ReadLine();
                            Console.Write("Nhap tuoi: ");
                            catx.tuoi = int.Parse(Console.ReadLine());
                            Chuong.DS_Animal.Add(catx);
                            break;
                        case "Tiger" :
                            Tiger tigerx = new Tiger();
                            Console.Write("Nhap ten: ");
                            tigerx.ten = Console.ReadLine();
                            Console.Write("Nhap mo ta: ");
                            tigerx.moTa = Console.ReadLine();
                            Console.Write("Nhap tuoi: ");
                            tigerx.tuoi = int.Parse(Console.ReadLine());
                            Chuong.DS_Animal.Add(tigerx);
                            break;
                    }
                    break;
                case 4 :
                    Console.Write("Nhap ten con vat muon xoa: ");
                    string ten = Console.ReadLine();
                    Chuong.xoaConVat(ten);
                    break;
                case 5 : 
                    Console.WriteLine("Tat ca con vat ban da nhap: ");
                    foreach(var i in Chuong.DS_Animal)
                    {
                        i.xemThongTin();
                        i.tiengKeu();
                    }
                    break;
                case 6 : return;
            }
        }
    }
}