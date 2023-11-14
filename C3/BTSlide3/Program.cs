using System.Reflection.Emit;
using System;
using System.Linq;
public class Organization
{
    #region Thuộc tính
    public string Name;
    public string Country;
    public string City;
    public string Address;
    public string Telephone;
    #endregion
    #region Constructors
    public Organization(string name,string country,string city,string address,string telephone)
    {
        Name = name;
        Country = country;
        City = city;
        Address = address;
        Telephone = telephone;
    }
    ~Organization()
    {
        Console.WriteLine("Doanh nghiep da duoc huy !");
    }
    public void Nhap()
    {
        Console.Write("Nhap ten doanh nghiep: ");
        Name = Console.ReadLine();
        Console.Write("Nhap Quoc gia: ");
        Country = Console.ReadLine();
        Console.Write("Nhap Thanh pho: ");
        City = Console.ReadLine();
        Console.Write("Nhap Dia chi: ");
        Address = Console.ReadLine();
        Console.Write("Nhap SDT: ");
        Telephone = Console.ReadLine();
    }
    public void Xuat()
    {
        Console.WriteLine("Thong tin ban da nhap: ");
        Console.WriteLine($"Doanh Nghiep: {Name}\nQuoc Gia: {Country}\nThanh Pho: {City}\nDia Chi: {Address}\nSDT: {Telephone}");
    }
    #endregion
}
class Program
{
    static bool KT(string n)
    {
        return string.IsNullOrEmpty(n);
    }
    static void Main()
    {
        Organization DN = new Organization("", "", "", "", "");
        DN.Nhap();
        if (KT(DN.Name) || KT(DN.Country) || KT(DN.City) || KT(DN.Address) || !(DN.Telephone).All(char.IsDigit) || (DN.Telephone).Length != 10  )
        {
            Console.WriteLine("Nhap thong tin loi !");
        }
        else DN.Xuat();
    }
}