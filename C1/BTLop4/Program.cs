using System;

namespace TinhTongSoMotChuSo
{
    class Program
    {
        static int Chuyen(int n)
        {
            int tong = 0;
            while (n > 0)
            {
                tong += n % 10;
                n /= 10;
            }
            return tong;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int tong = Chuyen(n);
            while (tong >= 10) tong = Chuyen(tong);
            Console.WriteLine(tong);
        }
    }
}
