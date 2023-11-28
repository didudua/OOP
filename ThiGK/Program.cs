
// Để quản lý sức khỏe người dân, yêu cầu xây dựng một chương trình quản lý bệnh tật như sau:
// Xây dựng lớp SUCKHOE (Sức khỏe) gồm các thuộc tính: CCCD (Căn cước công dân), TenBN(tên bệnh nhân), GioiTinh (Giới tính), Benh (Bệnh), Khuvuc (Khu vực), Mucdo (Mức độ).
// Từ đó xây dựng một chương trình quản lý dịch tễ, trong đó:
// 1. Xây dựng lớp SUCKHOE (Sức khỏe) với các thuộc tính ở phạm vi truy cập private (2 điểm)
// 2. Xây dựng lớp QuanlySuckhoe, là danh sách các bệnh nhân được nhập từ file .txt (2 điểm)
// 3. Tạo các phương thức quản lý bệnh nhân theo Menu sau:
// Bấm 1: Thêm (Thêm mới danh sách) (2 điểm)
// Bấm 2: Cách ly (Kiểm tra và xuất ra danh sách bệnh nhân cần được cách ly. Biết rằng, các bệnh cần cách ly là bệnh Lao và Covid) (2 điểm)
// Bấm 3: Sắp xếp (Sắp xếp bệnh nhân theo mức độ Bệnh) (2 điểm)
// Bấm 0: Exit
using System.Text;

public class SUCKHOE
{
    private string CCCD,TenBN,GioiTinh,Benh,Mucdo;
    public string GetCCCD()
    {
        return CCCD;
    }
    public string GetTenBN()
    {
        return TenBN;
    }
    public string GetGioiTinh()
    {
        return GioiTinh;
    }
    public string GetBenh()
    {
        return Benh;
    }
    public string GetMucdo()
    {
        return Mucdo;
    }
    public SUCKHOE(string CCCD,string TenBN,string GioiTinh,string Benh,string Mucdo )
    {
        this.CCCD = CCCD;
        this.TenBN = TenBN;
        this.GioiTinh = GioiTinh;
        this.Benh = Benh;
        this.Mucdo = Mucdo;
    }
}
public class QuanlySuckhoe
{
    public List<SUCKHOE> QL;
    public QuanlySuckhoe()
    {
        QL = new List<SUCKHOE>();
        string [] input = File.ReadAllLines("SucKhoe.txt");
        foreach(var dong in input)
        {
            var noidung = dong.Split(';');
            if (noidung.Length == 5 )
            {
                QL.Add(new SUCKHOE(noidung[0].Trim(),noidung[1].Trim(),noidung[2].Trim(),noidung[3].Trim(),noidung[4].Trim()));
            }
        }
    }
    public void Them()
    {
        int i=0;
        Console.Write("Nhap CCCD muon them: ");
        string cccd = Console.ReadLine();
        foreach (var benhnhan in QL)
        {
            if(benhnhan.GetCCCD() == cccd) 
            {
                Console.WriteLine("CCCD da ton tai: ");
                i++;
            }
        }
        if(i == 0 )
        {
            Console.Write("Nhap TenBN muon them: ");
            string ten = Console.ReadLine();
            Console.Write("Nhap GioiTinh muon them: ");
            string gioitinh = Console.ReadLine();
            Console.Write("Nhap Benh muon them: ");
            string benh = Console.ReadLine();
            Console.Write("Nhap MucDo muon them: ");
            string mucdo = Console.ReadLine();
            QL.Add(new SUCKHOE(cccd,ten,gioitinh,benh,mucdo));
        }
    }
    public void CachLy()
    {
        Console.WriteLine("Danh sach cach ly: ");
        foreach(var benhnhan in QL)
        {
            if(benhnhan.GetBenh() == "Lao" || benhnhan.GetBenh() == "Covid")
            {
                Console.WriteLine($"{benhnhan.GetCCCD()}; {benhnhan.GetTenBN()}; {benhnhan.GetGioiTinh()}; {benhnhan.GetBenh()}; {benhnhan.GetMucdo()}");
            }
        }
    }
    public List<SUCKHOE> Nang;
    public List<SUCKHOE> Nhe;
    public List<SUCKHOE> Trung;
    public void SapXep()
    {
        Nang = new List<SUCKHOE>();
        Nhe = new List<SUCKHOE>();
        Trung = new List<SUCKHOE>();

        Console.WriteLine("Danh sach da sx theo Mucdo: ");
        foreach(var benhnhan in QL)
        {
            if (benhnhan.GetMucdo() == "Nang") Nang.Add(benhnhan);
            if (benhnhan.GetMucdo() == "Nhe") Nhe.Add(benhnhan);
            if (benhnhan.GetMucdo() == "Trung binh") Trung.Add(benhnhan);
        }
        foreach(var benhnhan in Nang)
        {
            Console.WriteLine($"{benhnhan.GetCCCD()}; {benhnhan.GetTenBN()}; {benhnhan.GetGioiTinh()}; {benhnhan.GetBenh()}; {benhnhan.GetMucdo()}");
        }
        foreach(var benhnhan in Trung)
        {
            Console.WriteLine($"{benhnhan.GetCCCD()}; {benhnhan.GetTenBN()}; {benhnhan.GetGioiTinh()}; {benhnhan.GetBenh()}; {benhnhan.GetMucdo()}");
        }
                foreach(var benhnhan in Nhe)
        {
            Console.WriteLine($"{benhnhan.GetCCCD()}; {benhnhan.GetTenBN()}; {benhnhan.GetGioiTinh()}; {benhnhan.GetBenh()}; {benhnhan.GetMucdo()}");
        }
    }

}
class program
{
    static void Main()
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;
        Console.WriteLine(@"
        -----MENU-----
        Bấm 1: Thêm
        Bấm 2: Cách ly
        Bấm 3: Sắp xếp
        Bấm 0: Exit");
        QuanlySuckhoe QL = new QuanlySuckhoe();
        while (true)
        {
            Console.Write("Nhap Chuc Nang: ");
            int cn = int.Parse(Console.ReadLine());
            switch (cn)
            {
                case 1 : QL.Them(); break;
                case 2 : QL.CachLy(); break;
                case 3 : QL.SapXep(); break;
                case 0 : return;
            }
        }
    }
}
