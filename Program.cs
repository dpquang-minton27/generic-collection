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

            List<int> numbers = new List<int> { 2, 5, 8, 11, 14, 17, 20 };

            Console.WriteLine("Danh sách:");
            foreach (int n in numbers)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();

            int countEven = 0;
            foreach (int n in numbers)
            {
                if (n % 2 == 0)
                {
                    countEven++;
                }
            }

            Console.WriteLine("Số lượng số chẵn là: " + countEven);
            Console.ReadKey();
        }
    }
}