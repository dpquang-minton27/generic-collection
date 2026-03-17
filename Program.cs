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
=======
            List<int> numbers = new List<int> { 2, 5, 8, 11, 14, 17, 20 };

            Console.WriteLine("Danh sách:");
            foreach (int n in numbers)
=======
            Console.WriteLine("SV: Dương Phước Quang - MSSV: 2415053122131");

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
                if (!string.IsNullOrEmpty(keyword) &&
                    students[i].Equals(keyword, StringComparison.OrdinalIgnoreCase))
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
=======
                Console.WriteLine("\nKhông tìm thấy tên cần xóa!");
=======
                int demChan = 0;
                foreach (int x in ds)
                    if (x % 2 == 0) demChan++;

                Console.WriteLine("\nDanh sách đã nhập: " + string.Join(" ", ds));
                Console.WriteLine("Số lượng số chẵn = " + demChan);
            }
=======
            Console.WriteLine("Bài 02: Nhập List<int> và tính tổng các phần tử\n");

            List<int> ds = new List<int>();

            Console.WriteLine("Nhập các số nguyên (cách nhau bởi khoảng trắng). Ví dụ: 1 2 3 4 5");
            Console.Write("Nhập: ");
            string input = Console.ReadLine() ?? "";

            string[] parts = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string p in parts)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Danh sách sau khi xóa:");
            foreach (string name in students)
            {
                Console.Write(name + " ");
=======
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
=======
                Console.WriteLine("\nBạn chưa nhập số hợp lệ nào!");
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}