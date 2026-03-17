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
            Console.WriteLine("Đề bài: Nhập List<int>, tạo danh sách mới không chứa phần tử trùng.");
            Console.WriteLine("------------------------------");

            Console.Write("Nhập các số nguyên cách nhau bởi dấu cách: ");
            string input = Console.ReadLine();

            string[] parts = input.Split(new char[] { ' ', ',', ';' }, StringSplitOptions.RemoveEmptyEntries);
            List<int> numbers = new List<int>();

            foreach (string part in parts)
            {
                int n;
                if (int.TryParse(part, out n))
                {
                    numbers.Add(n);
                }
            }

            List<int> uniqueNumbers = new List<int>();

            foreach (int n in numbers)
            {
                if (!uniqueNumbers.Contains(n))
                {
                    uniqueNumbers.Add(n);
                }
            }

            Console.WriteLine("Danh sách không trùng lặp:");
            foreach (int n in uniqueNumbers)
            {
                Console.Write(n + " ");
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}