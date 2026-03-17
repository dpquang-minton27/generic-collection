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
            Console.WriteLine("Đề bài: Viết chương trình tìm giá trị nhỏ nhất trong List<int>.");
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

            if (numbers.Count == 0)
            {
                Console.WriteLine("Danh sách rỗng.");
                Console.ReadKey();
                return;
            }

            int min = numbers[0];
            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }

            Console.WriteLine("Phần tử nhỏ nhất là: " + min);
            Console.ReadKey();
        }
    }
}