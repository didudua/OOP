public abstract class Edition
{
    public string title,author;
    public static void CompareTo(Edition[] A)
    {
        Array.Sort(A, (x, y) => x.author.CompareTo(y.author));
    }
    public abstract void Xuat();
}
public class Book : Edition
{
    public int year;
    public string publisher;

    public override void Xuat()
    {
        Console.WriteLine($"Book: {title}, Tac Gia: {author}, Nam: {year}, NXB: {publisher}");
    }
}

public class Article : Edition
{
    public string journal;
    public override void Xuat()
    {
        Console.WriteLine($"Article: {title}, Tac Gia: {author}, Tap Chi: {journal}");
    }
}

public class OnlineResource : Edition
{
    public string Abstract,link;
    public override void Xuat()
    {
        Console.WriteLine($"Online Resource: {title}, Tac Gia: {author}, link: {link}, Tom Tat: {Abstract}");
    }
}
class Program
{
    static void Main()
    {
        int n = 3;
        Edition[] A = new Edition[n];
        A[0] = new Book { title = "Sach gi do", author = "DVV", year = 2023, publisher = "vanvu" };
        A[1] = new Article { title = "Bao gi do", author = "DVV", journal = "tap chi mot minh" };
        A[2] = new OnlineResource { title = "Online1", author = "VVD", link = "abcd.com", Abstract = "cai gi do trong rat tuyet" };
        foreach (var i in A)
        {
            i.Xuat();
        }
        Edition.CompareTo(A);
        Console.WriteLine("\nDa SX:");
        foreach (var i in A)
        {
            i.Xuat();
        }
        Console.WriteLine("\nKQ tac gia dang tim:");
        string tim = "DVV";
        int kt = 0;
        foreach(var i in A)
        {
            if(i.author == tim ) 
            {
                i.Xuat(); 
                kt++;
            }
        }
        if(kt == 0) Console.WriteLine("Khong tim thay tac gia !!");
    }
}
