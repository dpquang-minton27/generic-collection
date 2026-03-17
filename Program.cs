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
            Console.WriteLine("Đề bài: Tạo List<int>, đảo ngược thứ tự phần tử.");
            Console.WriteLine("------------------------------");

            List<int> numbers = new List<int> { 1, 36, 22, 55, 89, 46 };

            Console.WriteLine("Danh sách ban đầu:");
            foreach (int n in numbers)
            {
                Console.Write(n + " ");
            }

            Console.WriteLine();

            numbers.Reverse();

            Console.WriteLine("Danh sách sau khi đảo ngược:");
            foreach (int n in numbers)
            {
                Console.Write(n + " ");
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}