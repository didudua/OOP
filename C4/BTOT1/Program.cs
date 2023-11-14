    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;

    public class BDS
    {
        public string MaBDS, TenBDS, Huong, Diachi;
        public int Dientich;
        public float GiaBan;

        public BDS(string MaBDS, string TenBDS, string Huong, string Diachi, int Dientich, float GiaBan)
        {
            this.MaBDS = MaBDS;
            this.TenBDS = TenBDS;
            this.Huong = Huong;
            this.Diachi = Diachi;
            this.Dientich = Dientich;
            this.GiaBan = GiaBan;
        }
    }

    public class DanhsachBDS
    {
        public List<BDS> List_BDS;

        public DanhsachBDS()
        {
            List_BDS = new List<BDS>();

            string[] file = File.ReadAllLines("DanhSachBDS.txt");

            foreach (var Noidung in file)
            {
                var dong = Noidung.Split(';');
                if (dong.Length == 6)
                {
                    string MaBDS = dong[0].Trim();
                    string TenBDS = dong[1].Trim();
                    string Huong = dong[2].Trim();
                    string Diachi = dong[3].Trim();
                    int Dientich = int.Parse(dong[4].Trim());
                    float GiaBan = float.Parse(dong[5].Trim());
                    BDS bds = new BDS(MaBDS, TenBDS, Huong, Diachi, Dientich, GiaBan);
                    List_BDS.Add(bds);
                }
            }
        }


        public void SuaTT()
        {
            Console.Write("Nhập mã BDS muốn sửa: ");
            string Ma = Console.ReadLine();
            for (int i = 0; i < List_BDS.Count; i++)
            {
                if (List_BDS[i].MaBDS == Ma)
                {
                    Console.WriteLine("----- MENU -----");
                    Console.WriteLine("Bấm 1: Thay đổi Mã BDS\nBấm 2: Thay đổi Tên BDS\nBấm 3: Thay đổi Hướng BDS\nBấm 4: Thay đổi Địa chỉ BDS \nBấm 5: Thay đổi Diện tích BDS\nBấm 6: Thay đổi Giá Bán\nBấm 0: Exit");
                    while(true)
                    {
                        Console.Write("Nhập chức năng sửa: ");
                        int nhap = int.Parse(Console.ReadLine());
                        if (nhap == 0) break;
                        else if (nhap == 1)
                        {
                            Console.Write("Nhập Mã BDS: ");
                            List_BDS[i].MaBDS = Console.ReadLine();
                        }
                        else if (nhap == 2) 
                        {
                            Console.Write("Nhập Tên BDS: ");
                            List_BDS[i].TenBDS = Console.ReadLine();
                        }
                        else if (nhap == 3) 
                        {
                            Console.Write("Nhập Hướng BDS: ");
                            List_BDS[i].Huong = Console.ReadLine();
                        }
                        else if (nhap == 4) 
                        {
                            Console.Write("Nhập Địa chỉ BDS: ");
                            List_BDS[i].Diachi = Console.ReadLine();
                        }
                        else if (nhap == 5) 
                        {
                            Console.Write("Nhập Diện tích BDS: ");
                        List_BDS[i].Dientich = int.Parse(Console.ReadLine());
                        }
                        else if (nhap == 6) 
                        {
                            Console.Write("Nhập Giá Bán: ");
                            List_BDS[i].GiaBan = float.Parse(Console.ReadLine());
                        }
                    }
                }
            }
        }

        public void Xoathongtin()
        {
            Console.WriteLine("Nhập mã BDS muốn xóa: ");
            string Ma = Console.ReadLine();
            for (int i = 0; i < List_BDS.Count; i++)
            {
                if (List_BDS[i].MaBDS == Ma)
                {
                    List_BDS.RemoveAt(i);
                    Console.WriteLine("Đã được xóa !");
                }
            }
        }

        public void XuatDS()
        {
            Console.WriteLine("--- Danh sách bạn đã nhập ---");
            Console.WriteLine("MaBDS  TenBDS  Huong  Diachi  Dientich  GiaBan");
            foreach (var Bds in List_BDS)
            {
                Console.WriteLine($"{Bds.MaBDS};  {Bds.TenBDS};  {Bds.Huong};  {Bds.Diachi};  {Bds.Dientich};  {Bds.GiaBan}");
            }
        }

        public void TimTen()
        {
            Console.Write("Nhập tên BDS muốn tìm: ");
            string Ten = Console.ReadLine();
            Console.WriteLine("MaBDS  TenBDS  Huong  Diachi  Dientich  GiaBan");
            foreach (var Bds in List_BDS)
            {
                if (Bds.TenBDS == Ten)
                {
                    Console.WriteLine($"{Bds.MaBDS};  {Bds.TenBDS};  {Bds.Huong};  {Bds.Diachi};  {Bds.Dientich};  {Bds.GiaBan}");
                }
            }
        }

        public void TimHuong()
        {
            Console.Write("Nhập Hướng BDS muốn tìm: ");
            string Huong = Console.ReadLine();
            Console.WriteLine("MaBDS  TenBDS  Huong  Diachi  Dientich  GiaBan");
            foreach (var Bds in List_BDS)
            {
                if (Bds.Huong == Huong)
                {
                    Console.WriteLine($"{Bds.MaBDS};  {Bds.TenBDS};  {Bds.Huong};  {Bds.Diachi};  {Bds.Dientich};  {Bds.GiaBan}");
                }
            }
        }

        public void TimGia()
        {
            List<float> Gia = new List<float>();
            Console.WriteLine("Nhập khoảng Giá BDS muốn tìm ([a,b]): ");
            Console.Write("Nhập a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhập b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("MaBDS  TenBDS  Huong  Diachi  Dientich  GiaBan");
            foreach (var Bds in List_BDS)
            {
                if (Bds.GiaBan >= a && Bds.GiaBan <= b)
                {          
                    Gia.Add(Bds.GiaBan);
                }
            }
            Gia.Sort();
            HashSet<float> Gia_New = new HashSet<float>(Gia);
            foreach (var gia in Gia_New)
            {
                foreach(var Bds in List_BDS)
                {
                    if(Bds.GiaBan == gia)
                    {
                        Console.WriteLine($"{Bds.MaBDS};  {Bds.TenBDS};  {Bds.Huong};  {Bds.Diachi};  {Bds.Dientich};  {Bds.GiaBan}");
                    }
                }
            } 
        }
    }

    class Program
    {
        static void Main()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("----- MENU -----");
            Console.WriteLine("Bấm 1: Thêm mới danh sách\nBấm 2: Sửa thông tin\nBấm 3: Xóa thông tin\nBấm 4: Xuất danh sách \nBấm 5: Tìm theo Tên\nBấm 6: Tìm theo Hướng\nBấm 7: Tìm theo Giá\nBấm 0: Exit");

            DanhsachBDS danhsach = null;

            while (true)
            {
                Console.Write("Nhập chức năng chính: ");
                int kt = int.Parse(Console.ReadLine());

                if (kt == 0) break;
                else if (kt == 1) danhsach = new DanhsachBDS();
                else if (kt == 2) danhsach.SuaTT();
                else if (kt == 3) danhsach.Xoathongtin();
                else if (kt == 4) danhsach.XuatDS();
                else if (kt == 5) danhsach.TimTen();
                else if (kt == 6) danhsach.TimHuong();
                else if (kt == 7) danhsach.TimGia();
            }
        }
    }
    