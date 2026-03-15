using System;
using System.Collections.Generic;
using System.Text;

namespace generic_collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Console.WriteLine("SV: Dương Phước Quang - MSSV: 2415053122131");

            Console.WriteLine("Bài 02: Nhập List<int> và tính tổng các phần tử\n");

            List<int> ds = new List<int>();

            Console.WriteLine("Nhập các số nguyên (cách nhau bởi khoảng trắng). Ví dụ: 1 2 3 4 5");
            Console.Write("Nhập: ");
            string input = Console.ReadLine() ?? "";

            string[] parts = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string p in parts)
            {
                if (int.TryParse(p, out int n))
                    ds.Add(n);
            }

            if (ds.Count == 0)
            {
                Console.WriteLine("\nBạn chưa nhập số hợp lệ nào!");
            }
            else
            {
                int tong = 0;
                foreach (int x in ds) tong += x;

                Console.WriteLine("\nDanh sách đã nhập: " + string.Join(" ", ds));
                Console.WriteLine("Tổng các phần tử = " + tong);
            }
=======
            Console.WriteLine("Bài 01: Tạo List<int>, nhập 5 số và in ra màn hình\n");

            List<int> ds = new List<int>();

            for (int i = 1; i <= 5; i++)
            {
                while (true)
                {
                    Console.Write($"Nhập số nguyên thứ {i}: ");
                    string s = Console.ReadLine() ?? "";

                    if (int.TryParse(s, out int n))
                    {
                        ds.Add(n);
                        break;
                    }

                    Console.WriteLine("Bạn nhập sai! Vui lòng nhập lại số nguyên.\n");
                }
            }

            Console.WriteLine("\nCác phần tử trong danh sách:");
            Console.WriteLine(string.Join(" ", ds));

            Console.WriteLine("\nNhấn Enter để kết thúc...");
            Console.ReadLine();
        }
    }
}