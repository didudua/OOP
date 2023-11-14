
// using System.Text;

// Console.OutputEncoding=Encoding.UTF8;
// Console.WriteLine("xin chào tất cả mọi người");

// using System.Text;

// namespace xin
// {
//     class Program
//     {
//         static void TestToanHoc()
//         {
//             Console.OutputEncoding=Encoding.UTF8;
//             Console.Write("Mời bạn nhập vào số a: ");
//             string a = string.Parse(Console.ReadLine());
//             Console.WriteLine("Căn bậc hai của {0} = {1}", a, Math.Round(Math.Sqrt(a),2));
//             Console.ReadLine();
//         }

//         static void Main(string[] args)
//         {
//             TestToanHoc();
//         }
//     }
// // }
// using System.Text;
// using System;
// class Program
// {
//     static void Main()
//     {
//         Console.OutputEncoding=Encoding.UTF8;
//         string[] file = File.ReadAllLines("test.txt");
//         foreach(var i in file)
//         {
//             Console.WriteLine(i);
//             Console.WriteLine();
//         }
//     }
// }
string text = @"a
bb
c ";
Console.WriteLine(text);