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
            Console.WriteLine("Bài 03: Nhập List<int> và tìm số lớn nhất\n");

            List<int> ds = new List<int>();

            Console.WriteLine("Nhập các số nguyên (cách nhau bởi khoảng trắng). Ví dụ: 3 7 1 9 5");
            Console.Write("Nhập: ");
            string input = Console.ReadLine() ?? "";

            char[] tach = new[] { ' ', '\t' };
            string[] parts = input.Split(tach, StringSplitOptions.RemoveEmptyEntries);

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
                int max = ds[0];
                foreach (int x in ds)
                    if (x > max) max = x;

                Console.WriteLine("\nDanh sách đã nhập: " + string.Join(" ", ds));
                Console.WriteLine("Số lớn nhất = " + max);
            }

            Console.WriteLine("\nNhấn Enter để kết thúc...");
            Console.ReadLine();
        }
    }
}