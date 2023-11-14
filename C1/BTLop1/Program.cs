using System;

namespace BTLop1
{
    class Program
    {
        static bool SNT(int j)
        {
            if (j <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(j); i++)
            {
                if (j % i == 0) return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            int a, b,tong=0;
            Console.Write("Nhap a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhap b: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("tong SNT trong doan [{0},{1}]", a, b);

            for (int j = a; j <= b; j++)
            {
                if (SNT(j)) tong+=1;
            }
            Console.WriteLine(tong);
        }
    }
}
