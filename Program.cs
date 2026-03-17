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
            Console.WriteLine("Đề bài: Nhập List<int>, tìm số xuất hiện nhiều nhất.");
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

            Dictionary<int, int> counter = new Dictionary<int, int>();

            foreach (int n in numbers)
            {
                if (counter.ContainsKey(n))
                {
                    counter[n]++;
                }
                else
                {
                    counter[n] = 1;
                }
            }

            int maxCount = 0;
            int mostFrequent = numbers[0];

            foreach (int n in numbers)
            {
                if (counter[n] > maxCount)
                {
                    maxCount = counter[n];
                    mostFrequent = n;
                }
            }

            Console.WriteLine("Phần tử xuất hiện nhiều nhất là: " + mostFrequent);
            Console.WriteLine("Số lần xuất hiện: " + maxCount);
            Console.ReadKey();
        }
    }
}