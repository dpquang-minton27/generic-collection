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

            List<string> students = new List<string> { "An", "Bình", "Cường", "Dung", "Hà" };

            Console.WriteLine("Danh sách sinh viên ban đầu:");
            foreach (string name in students)
            {
                Console.Write(name + " ");
            }
            Console.WriteLine();

            Console.Write("Nhập tên cần xóa: ");
            string keyword = Console.ReadLine();

            int index = -1;
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].Equals(keyword, StringComparison.OrdinalIgnoreCase))
                {
                    index = i;
                    break;
                }
            }

            if (index != -1)
            {
                students.RemoveAt(index);
                Console.WriteLine("Đã xóa tên: " + keyword);
            }
            else
            {
                Console.WriteLine("Không tìm thấy tên cần xóa.");
            }

            Console.WriteLine("Danh sách sau khi xóa:");
            foreach (string name in students)
            {
                Console.Write(name + " ");
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}