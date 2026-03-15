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