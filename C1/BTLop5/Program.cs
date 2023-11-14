using System;
using System.Reflection.Metadata;

namespace TinhTongSoMotChuSo
{
    class Program
    {
        static bool SNT(int a)
        {
            if (a==1) return false;
            if (a==2) return true;
            for (int i = 2; i<a;i++)
            {
                if (a%i==0) return false;
            }
            return true;
        }
        static int UCLN(int b,int c)
        {
            if (c==0) return b;
            return UCLN(c,b%c);
        }
        static void Main(string[] args)
        {
            int dem=0;
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            string nhap = Console.ReadLine();
            string [] A = nhap.Split(" ");
            int []B=new int[n];
            for ( int i =0;i<n;i++)
            {
                B[i]=int.Parse(A[i]);
            }
            for (int i = 0; i<n;i++)
            {
                // if (SNT(B[i]))
                // {
                    for (int j = i+1;j<n;j++)
                    {
                        // if (SNT(B[j]))
                        // {
                            if (UCLN(B[i],B[j])== 1) 
                            {
                            // Console.WriteLine($"{B[i]} {B[j]}"); 
                            dem+=1;
                            }
                        // }
                    }
                // }
            }
            Console.WriteLine(dem);
        }
    }
}
