// using System.Reflection.Emit;
// using System.Data;
// using Internal;
// using System;
namespace timhieu
{
    class Program
    {  
        static void TBP(ref int a,ref int b)
        {
            Console.WriteLine("cau a: {0}",a*a+b*b);
        }
        static void TBP(int a,int b,ref int kq)
        {
            kq=a*a+b*b;
        }
        static int TBP( int a,int b)
        {
            return a*a+b*b;
        }
        static void Main(string[] args)
        {
               
            int a,b,kq=0;
            Console.Write("nhap a: ");
            a=int.Parse(Console.ReadLine());
            Console.Write("nhap b: ");
            b=int.Parse(Console.ReadLine());
            Console.WriteLine("Tong binh phuong cua a va b la:");
            TBP(ref a,ref b);
            TBP(a,b, ref kq);
            Console.WriteLine("cau b: {0}",kq);
            Console.WriteLine("cau c: {0}",TBP(a,b));
        }
    }
}
