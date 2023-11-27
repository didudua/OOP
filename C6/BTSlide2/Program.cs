interface tinhnang
{
    void kiemtra(int i);
}
class Quat : tinhnang
{
    public void kiemtra(int i)
    {
        if (i==0) Console.WriteLine("Quat dang bat");
        else Console.WriteLine("Quat dang tat");
    }
}
class DieuHoa : tinhnang
{
    public void kiemtra(int i)
    {
        if (i==0) Console.WriteLine("Dieu Hoa dang bat");
        else Console.WriteLine("Dieu Hoa dang tat");
    }
}
class Tivi : tinhnang
{
    public void kiemtra(int i)
    {
        if (i==0) Console.WriteLine("Tivi dang bat");
        else Console.WriteLine("Tivi dang tat");
    }
}
class program
{
    static void Main()
    {
        Quat a = new Quat();
        a.kiemtra(0);
        DieuHoa b = new DieuHoa();
        b.kiemtra(1);
        Tivi c = new Tivi();
        c.kiemtra(2);
    }
}