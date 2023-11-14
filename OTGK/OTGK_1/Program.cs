
// tạo danh sách đồ chơi có, Masp,Tensp,Dotuoi,Phanloai,giaban
// tạo menu có :
// 1. Them moi danh sach
// 2. sap xep do choi theo gia
// 3. tim va xuat danh sach do choi (theo phanloai)
using System;
using System.Collections.Generic;
using System.IO;

public class Toy
{
    public string MaSP, TenSP, DoTuoi, PhanLoai;
    public int GiaBan;

    public Toy(string masp, string tensp, string dotuoi, string phanloai, int giaban)
    {
        MaSP = masp;
        TenSP = tensp;
        DoTuoi = dotuoi;
        PhanLoai = phanloai;
        GiaBan = giaban;
    }
}

public class DSToy
{
    public List<Toy> DS_Toy = new List<Toy>();

    public void Nhap()
    {
        string[] input = File.ReadAllLines("Toy.txt");
        foreach (var dong in input)
        {
            var thongtin = dong.Split(";");
            if (thongtin.Length == 5) 
            {
                DS_Toy.Add(new Toy(thongtin[0].Trim(), thongtin[1].Trim(), thongtin[2].Trim(), thongtin[3].Trim(), int.Parse(thongtin[4].Trim())));
            }
        }
    }

    public void SapXep()
    {
        DS_Toy.Sort((x, y) => x.GiaBan.CompareTo(y.GiaBan)); // SẮP XẾP GIÁ THEO THỨ TỰ TĂNG DẦN ĐỐI TƯỢNG CŨNG ĐƯỢC SX THEO
        // DS_Toy.Sort((x, y) => y.GiaBan.CompareTo(x.GiaBan)); // SẮP XẾP GIÁ THEO THỨ TỰ GIẢM DẦN ĐỐI TƯỢNG CŨNG ĐƯỢC SX THEO
        foreach(var i in DS_Toy)
        {
            if (i.GiaBan >=150000) Console.WriteLine($"{i.MaSP}   {i.TenSP}   {i.DoTuoi}   {i.PhanLoai}   {i.GiaBan}");
        }
    }

    public void TimvaXuat()
    {
        Console.Write("Nhap phan loai muon tim: ");
        string pl = Console.ReadLine();
        Console.WriteLine("MaSP   TenSP   DoTuoi   PhanLoai   GiaBan");
        foreach (var i in DS_Toy)
        {
            if (i.PhanLoai == pl)
            {
                Console.WriteLine($"{i.MaSP}; {i.TenSP}; {i.DoTuoi}; {i.PhanLoai}; {i.GiaBan}");
            }
        }
    }
}

class Program
{
    static void Main()
    {
        DSToy DS = new DSToy();
        DS.Nhap();
        DS.SapXep();
        DS.TimvaXuat();
    }
}
