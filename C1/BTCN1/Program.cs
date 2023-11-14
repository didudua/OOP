using System;
namespace C1B1
{
    class Program
    {
        static void Tinh(float QTH,float CSLT,float Triet,float HTTTQL,out float GPA)
        {
            GPA = 0;
            float [] A= { QTH, CSLT, Triet,HTTTQL};
            foreach (float i in A)
            {
                if ( i>=8.5)
                {
                    // Console.WriteLine("{0}",i);
                    GPA += 4;
                }
                else if ( i>=7 & i<8.5)
                {
                    // Console.WriteLine("{0}",i);
                    GPA += 3;
                }
                else if ( i>=5.5 & i<7)
                {
                    // Console.WriteLine("{0}",i);
                    GPA += 2;
                }
                else if ( i>4 & i<5.5)
                {
                    // Console.WriteLine("{0}",i);
                    GPA += 1;
                }
                else
                {
                    // Console.WriteLine("{0}",i);
                    GPA += 0;
                }
            }
            GPA = GPA/4;

        }
        static void XEPLOAI(ref string ten, ref string lop, float QTH, float HTTTQL, float CSLT, float Triet,float GPA)
        {
            // Xuất sắc: Nếu GPA >=3.6
            // Giỏi: Nếu 3.2<GPA <3.6
            // Khá: Nếu 2.5 < GPA <3.2
            // Trung bình: Nếu 2<GPA <2.5
            // Yếu: Nếu Điểm < 2
            if (GPA >= 3.6)
            {
                Console.WriteLine("Sinh vien {0}, Lop {1}, Dat GPA {2}, Xep loai Xuat sac",ten.ToUpper(),lop,GPA);
            }
            else if (3.2 < GPA && GPA <3.6)
            {
                Console.WriteLine("Sinh vien {0}, Lop {1}, Dat GPA {2}, Xep loai Gioi",ten.ToUpper(),lop,GPA);
            }
            else if (2.5 < GPA && GPA <3.2)
            {
                Console.WriteLine("Sinh vien {0}, Lop {1}, Dat GPA {2}, Xep loai Kha",ten.ToUpper(),lop,GPA);
            }
            else if (2 < GPA && GPA <2.5)
            {
                Console.WriteLine("Sinh vien {0}, Lop {1}, Dat GPA {2}, Xep loai Trung binh",ten.ToUpper(),lop,GPA);
            }
            else
            {
                Console.WriteLine("Sinh vien {0}, Lop {1}, Dat GPA {2}, Xep loai Yeu",ten.ToUpper(),lop,GPA);
            }

        }
        static void Main(string[] args)
        {
            // Diem_QTH: 7.5
            // Diem_HTTTQL: 9.2
            // Diem_CSLT: 7.5
            // Diem_Triet: 8.8
            float QTH, HTTTQL, CSLT,Triet,GPA;
            Console.Write("Ho va ten: ");
            string ten=Console.ReadLine();
            Console.Write("Lop: ");
            string lop=Console.ReadLine();
            Console.Write("Diem_QTH: ");
            QTH=float.Parse(Console.ReadLine());
            Console.Write("Diem_HTTTQL: ");
            HTTTQL=float.Parse(Console.ReadLine());
            Console.Write("Diem_CSLT: ");
            CSLT=float.Parse(Console.ReadLine());
            Console.Write("Diem_Triet: ");
            Triet=float.Parse(Console.ReadLine());
            Tinh(QTH,CSLT,Triet,HTTTQL,out GPA);
            XEPLOAI(ref ten, ref lop, QTH, HTTTQL, CSLT, Triet,GPA);
        }
    }
}