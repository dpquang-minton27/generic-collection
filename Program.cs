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
            Console.WriteLine("Bài 04: Tạo List<int>, đếm bao nhiêu số chẵn\n");

            List<int> ds = new List<int>();

            Console.WriteLine("Nhập các số nguyên (cách nhau bởi khoảng trắng). Ví dụ: 2 5 8 11 14 7");
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
                int demChan = 0;
                foreach (int x in ds)
                    if (x % 2 == 0) demChan++;

                Console.WriteLine("\nDanh sách đã nhập: " + string.Join(" ", ds));
                Console.WriteLine("Số lượng số chẵn = " + demChan);
            }

            Console.WriteLine("\nNhấn Enter để kết thúc...");
            Console.ReadLine();
        }
    }
}