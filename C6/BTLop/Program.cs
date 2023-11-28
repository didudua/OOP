// Bài 1. Công viên Asia Park bán vé vui chơi với giá vé trọn gói là 250.000đ/ người lớn,
// 130.000đ/ trẻ em trên 1m, và miễn phí cho trẻ em đưới 1m. Khách đến chơi gồm có người lớn và trẻ em.
// Viết chương trình quán lý thông tin mua vé, gồm các thông tin:
// Đối với khách hàng là người lớn: Tên khách hàng, CMND, Giá vé.
// Đối với khách hàng là trẻ em: Tên khách hàng, chiều cao, Giá vé.
// Sau khi mua vé thi khách hàng sẽ được đeo thẻ như sau: Người lớn sẽ mang thẻ đỏ, trẻ em sẽ được mang thẻ xanh.
// Tính doanh thu của công viên sau một lượt tham quan. 
abstract public class khachhang
{
    public string ten;
    public int gia = 250;
    abstract public void Xuat();
}
class Adult : khachhang 
{
    public string cmnd;
    public override void Xuat()
    {
        Console.WriteLine($"The Do: Ten: {ten}, CMND: {cmnd}, Gia ve: {gia}k");
    }
}
class Children : khachhang
{
    public double chieucao;
    public Children(string Ten, double ChieuCao)
    {
        chieucao = ChieuCao;
        ten = ten;
        if(chieucao <= 1) gia = 0;
        else gia = 130;
    }
    public override void Xuat()
    {
        Console.WriteLine($"The Xanh: Ten: {ten}, Chieu cao: {chieucao}, Gia ve: {gia}k");
    }
}
class program
{
    static void Main()
    {
        List<khachhang> DS_KH = new List<khachhang>();
        DS_KH.Add( new Adult {ten = "Hoa", cmnd = "123456789"});
        DS_KH.Add( new Adult {ten = "Khoa", cmnd = "11223344"});
        DS_KH.Add( new Adult {ten = "Khanh", cmnd = "1445644323"});
        DS_KH.Add(new Children ("Anh",1.4));
        DS_KH.Add(new Children ("Oanh",1));
        Console.WriteLine("thong tin khach hang");
        int tongtien = 0;
        foreach(var i in DS_KH)
        {
            i.Xuat();
            tongtien += i.gia;
        }
        Console.WriteLine($"\nDoanh Thu: {tongtien}k");
    }
}