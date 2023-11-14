using System;
public class DoanhNghiep
{
    public string TenDN,MST,Diachi;
    public DoanhNghiep()
    {
        Console.Write("Ten DN: ");
        TenDN = Console.ReadLine();
        Console.Write("Ma so thue: ");
        MST = Console.ReadLine();
        Console.Write("Dia Chi: ");
        Diachi = Console.ReadLine();
        Console.WriteLine();
    }
}
public class DanhsachDN
{
    public List<DoanhNghiep> List_DN;
    public DanhsachDN()
    {
        List_DN = new List<DoanhNghiep>();
        DoanhNghiep A = new DoanhNghiep();
        List_DN.Add(A);
        DoanhNghiep B = new DoanhNghiep();
        List_DN.Add(B);
        DoanhNghiep C = new DoanhNghiep();
        List_DN.Add(C);
    }
    public void Xuat()
    {
        foreach (var dn in List_DN)
        {
            Console.WriteLine($"Ten DN: {dn.TenDN}, MST: {dn.MST}, Dia Chi: {dn.Diachi}");
        }
    }
    public string TimMST(string Ten)
    {
        for (int i = 0; i<List_DN.Count; i++)
        {
            if (List_DN[i].TenDN == Ten)  return List_DN[i].MST;
        }
        return "";
    }
    public void TimTenvaDC(string mst,out string ten, out string diachi)
    {
        ten = "";
        diachi = "";
        for (int i = 0; i<List_DN.Count; i++)
        {
            if (List_DN[i].MST == mst) 
            {
                ten = List_DN[i].TenDN;
                diachi = List_DN[i].Diachi;
            }
        }
    }
}
class program
{
    static void Main()
    {
        string ten,diachi;
        DanhsachDN ABC = new DanhsachDN();
        Console.WriteLine("***** Danh Sach *****");
        ABC.Xuat();
        Console.WriteLine();
        Console.Write("Nhap Ten DN muon tim MST: ");
        string Ten = Console.ReadLine();
        if (ABC.TimMST(Ten) != "") Console.WriteLine($"DN {Ten} co MST la: {ABC.TimMST(Ten)}");
        else Console.WriteLine($"Khong tim thay MST cua Dn {Ten}");
        Console.Write("Nhap MST muon tim Ten DN va Dia chi: ");
        string mst = Console.ReadLine();
        ABC.TimTenvaDC(mst, out ten, out diachi);
        if (ten != "" || diachi != "") Console.WriteLine($"Dn co MST: {mst} la Dn: {ten}, Dia chi: {diachi}");
        else Console.WriteLine($"Khong tim thay DN co MST {mst}");
    }
}