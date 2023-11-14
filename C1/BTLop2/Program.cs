 namespace BTLop2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            float tong =0;
            Console.Write("nhap n: ");
            n=int.Parse(Console.ReadLine());
            for (float i=1; i<2*n; i+=2)
            {
                tong += 1/i ;
            }
            Console.WriteLine("tong nghich dao cac so le Sn: {0}",tong);

        }
    }
}
