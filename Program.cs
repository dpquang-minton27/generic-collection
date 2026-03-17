using System;
using System.Collections.Generic;
using System.Text;

namespace generic_collection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Tên: Dương Phước Quang");
            Console.WriteLine("MSV: 2415053122131");
            Console.WriteLine("------------------------------");

            List<string> words = new List<string> { "cam", "xoài", "táo", "ổi", "chuối" };

            Console.WriteLine("Danh sách hiện có:");
            foreach (string word in words)
            {
                Console.Write(word + " ");
            }
            Console.WriteLine();

            Console.Write("Nhập chuỗi cần kiểm tra: ");
            string keyword = Console.ReadLine();

            bool found = false;

            if (!string.IsNullOrEmpty(keyword))
            {
                for (int i = 0; i < words.Count; i++)
                {
                    if (words[i].Equals(keyword, StringComparison.OrdinalIgnoreCase))
                    {
                        found = true;
                        break;
                    }
                }
            }

            if (found)
            {
                Console.WriteLine("Chuỗi tồn tại trong danh sách.");
            }
            else
            {
                Console.WriteLine("Chuỗi không tồn tại trong danh sách.");
            }

            Console.ReadKey();
        }
    }
}