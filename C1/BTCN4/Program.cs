using System;
using System.ComponentModel;
using System.Data;
using System.Reflection.Metadata;

namespace C1B4
{
    class Program
    {
        static void Main(string[] args)
        {
            // int n=4,max;
            int n,max;
            // int [,] A = { {0,0,0,1}
            //             , {3,0,3,1}
            //             , {3,0,0,1}
            //             , {1,1,1,0} };

            n=int.Parse(Console.ReadLine());
            int [] Tong = new int[n]; // tong diem moi team
            int [] Thang = new int[n]; // so tran thang moi team
            int [] Dem = new int[n]; // so tran thang + hoa cua moi team
            int [,] A = new int [n,n];
            for (int m=0; m<n; m++)
            {
                string nhap = Console.ReadLine();
                string []B = nhap.Split(" ");
                for (int b=0; b<n; b++)
                {
                    A[m,b]=int.Parse(B[b]);
                }
            }
            for (int i = 0; i < n; i++)
            {
                int thang =0, thua =-1,tong=0,w,dem=0;
                for (int j = 0; j < n; j++)
                {
                    tong += A[i,j];

                    if (A[i,j] ==3) thang +=1;
                    if (A[i,j] ==0) thua +=1;
                    if (A[i,j] !=0) dem+=1;

                }
                Tong[i]=tong;

                if (thang > thua) w=1;
                else w = 0;
                Thang[i]=w;
                Dem[i]=dem;
            }

            max = Tong[0];
            foreach ( int q in Tong)
            {
                max = Math.Max(max,q);
            }
            for (int k = 0; k < n; k++)
            {
                if (Tong[k]==max)
                {
                    Console.Write("{0} ",k+1);
                }
            }

            Console.WriteLine();

            for (int p = 0; p < n; p++)
            {
                if (Thang[p]==1)
                {
                    Console.Write("{0} ",p+1);
                }
            }
            
            Console.WriteLine();
            for (int a = 0; a < n; a++)
            {
                if (Dem[a]==3)
                {
                    Console.Write("{0} ",a+1);
                }
            }
            
        }
    }
}