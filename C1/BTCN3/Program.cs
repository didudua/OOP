using System;
using System.Globalization;
using System.Threading.Channels;

namespace C1B3
{
    class Program
    {
        static float [] Nhap(int n)
        {
            float []A= new float [n];
            Console.Write("A = ");
            string nhap = Console.ReadLine();
            nhap = nhap.Trim('[', ']'); // xoa char '[', ']' trong string nhap
            string []B = nhap.Split(",");
            for (int i=0; i<n; i++)
            {
                A[i]=float.Parse(B[i]); // chuyển B[i] thanh
            }
            return A;

        }
        static void Main(string[] args)
        {
            int n=0;
            float tong =0,tich=1,max,min;
            float[] A,chan,le;
            Console.Write("n = ");
            n=int.Parse(Console.ReadLine());
            A = Nhap(n);
            for (int i = 0; i < n; i++)
            {
                if (A[i] <0)
                {
                    tong += A[i]*(-1);
                }
            }  
            max = A[0];
            min = A[0];
            foreach ( float i in A)
            {
                max = Math.Max(max, i);
                min = Math.Min(min, i);
            }
            for ( int i=0; i < n; i++)
            {
                if (A[i] == max | A[i] == min)
                {
                    for (int j=i+1;j<n;j++)
                    {
                        if (A[j] == max | A[j] == min)
                        {
                            break;
                        } 
                        tich *= A[j];
                    }
                    break;
                }

            }
            Console.WriteLine("Tong = {0}",tong);
            Console.WriteLine("Tich = {0}",tich);
            Array.Sort(A); // sap xep tang dan
            Console.Write("A_tang= [");
            for (int k=0; k < n; k++)
            {
                if (k==n-1)
                {
                    Console.WriteLine("{0}]",A[k]);
                }
                else
                {
                Console.Write("{0},",A[k]);
                }
            }
            chan = new float [0];
            le = new float [0];
            foreach(int z in A)
            {
                int h = (int)z;
                if (h%2==0)
                {
                    Array.Resize(ref chan, chan.Length + 1); // thay doi kich thuoc cua mang
                    chan[chan.Length - 1] = h; // them phan tu vao mang
                }
                else
                {
                    Array.Resize(ref le, le.Length + 1);
                    le[le.Length - 1] = h;
                }
            }
            Array.Sort(chan);
            Array.Sort(le);
            Console.Write("A_biendoi = [");
            foreach (int q in chan)
            {
                Console.Write("{0},",q);
            }
            for (int p = 0; p < le.Length; p++)
            {
                if (p==le.Length-1)
                {
                    Console.Write("{0}]", le[p]);
                }
                else
                {
                    Console.Write("{0},", le[p]);
                }
            }
        }
    }
}