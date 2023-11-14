using System;
namespace C1B2
{
    class Program
    {
        static void Nhap(out float a, out float b, out string tt)
        {
            Console.Write("a=");
            a=float.Parse(Console.ReadLine());
            Console.Write("b=");
            b=float.Parse(Console.ReadLine());
            Console.Write("Toan tu: ");
            tt=Console.ReadLine();
        }
        static void Thuchien(ref float a, ref float b, string tt, out float kq)
        {
            kq=0;
            if (tt == "+")
            {
                kq=a+b;
            }
            else if (tt == "-")
            {
                kq=a-b;
            }
            else if (tt == "*")
            {
                kq=a*b;
            }
            else if (tt == "/")
            {
                kq=a/b;
            }
        }
        static void InKQ(float a,string tt, float b, float kq, ref string tiep)
        {
            Console.WriteLine("{0} {1} {2}= {3}", a,tt, b, kq);
            Console.Write("Tiep tuc: ");
            tiep = Console.ReadLine();
        }
        static void Main(string[] args)
        {
            string tiep ="";
           do {
            float a,b,kq;
            string tt;
            Nhap(out a, out b, out tt);
            Thuchien(ref a, ref b, tt, out kq);
            InKQ(a,tt,b,kq, ref tiep);
            }while (tiep != "t" & tiep != "T");
        }
    }
}
