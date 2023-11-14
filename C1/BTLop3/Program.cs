 namespace BTLop3
{
    class Program
    {
        static string[] Nhap()
        {
            string nhap=Console.ReadLine();
            string[] New = new string[nhap.Length];

            for (int i = 0; i < nhap.Length; i++)
            {
                New[i] = nhap[i].ToString();
            }
            return New;
        }
        static void Main(string[] args)
        {
            // A: 0 0 1 1 
            // B: 0 1 0 1
            // A XOR B : 0 1 1 0
            string []A,B;
            Console.Write("A: ");
            A=Nhap();
            Console.Write("B: ");
            B=Nhap();
            // string M = string.Join(",",A);
            // string  N= string.Join(",",B);
            // Console.WriteLine("{0},{1}",D,C);
            string []C=new string [A.Length];
            for (int i=0; i<A.Length; i++)
            {
                if (A[i] == B[i]) C[i]="0";
                else C[i]="1";
                // Console.WriteLine("{0} {1} {2}",C[i],A[i],B[i]);
            }
            string XOR = string.Join("",C);
            Console.WriteLine("C = A XOR B = {0}",XOR);
        }
    }
}