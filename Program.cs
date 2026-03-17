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
            Console.WriteLine("Đề bài: Nhập một chuỗi, dùng Dictionary<char, int> để đếm số lần xuất hiện của mỗi ký tự.");
            Console.WriteLine("------------------------------");

            Console.Write("Nhập một chuỗi: ");
            string text = Console.ReadLine();

            Dictionary<char, int> counter = new Dictionary<char, int>();

            foreach (char c in text)
            {
                if (c == ' ')
                {
                    continue;
                }

                if (counter.ContainsKey(c))
                {
                    counter[c]++;
                }
                else
                {
                    counter[c] = 1;
                }
            }

            Console.WriteLine("Số lần xuất hiện của mỗi ký tự:");
            foreach (KeyValuePair<char, int> item in counter)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }

            Console.ReadKey();
        }
    }
}