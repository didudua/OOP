using System;
using System.Text;
namespace BTLop4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding=Encoding.UTF8;
            int tong=0;
            string nhap;
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Giá trị lần lượt của mặt hàng là: ");
            nhap = Console.ReadLine();
            string[] A= nhap.Split(" ");
            List<string> C = new List<string>(A);
            List<int> B = C.Select(int.Parse).ToList();
            foreach ( int a in B) tong+= a;
            if (n>=3)
            {
                int tru = (int)(n/3);
                do
                {
                    for ( int i = 0;i<n;i++)
                    {
                        if ( B[i] == B.Min()) 
                        {
                        tong -= B[i];
                        // Console.WriteLine(B[i]);
                        B.RemoveAt(i);
                        tru-=1;
                        break;
                        }
                    }
                }while ( tru !=0);
            }
            Console.Write($"Tổng số tiền phải trả là: {tong}");
        }
    }
}
