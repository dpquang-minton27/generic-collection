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
=======
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
=======
            {
                int n;
                if (int.TryParse(part, out n))
                {
                    numbers.Add(n);
                }
=======
            Console.WriteLine("Đề bài: Tạo List<int>, đảo ngược thứ tự phần tử.");
            Console.WriteLine("------------------------------");

            List<int> numbers = new List<int> { 1, 36, 22, 55, 89, 46 };

            Console.WriteLine("Danh sách ban đầu:");
            foreach (int n in numbers)
            {
=======
            Console.WriteLine("Đề bài: Nhập List<int>, sắp xếp tăng dần và in kết quả.");
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
=======
            Console.WriteLine("------------------------------");

            List<string> words = new List<string> { "cam", "xoài", "táo", "ổi", "chuối" };
=======
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
=======
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

            Console.WriteLine("Danh sách hiện có:");
            foreach (string word in words)
            {
                Console.Write(word + " ");
            }
            Console.WriteLine();

            Console.Write("Nhập chuỗi cần kiểm tra: ");
            string keyword = Console.ReadLine();

            bool found = false;
=======
            Console.WriteLine("Nhập các số nguyên (cách nhau bởi khoảng trắng). Ví dụ: 1 2 3 4 5");
            Console.Write("Nhập: ");
            string input = Console.ReadLine() ?? "";

            Console.WriteLine("Phần tử nhỏ nhất là: " + min);
=======
            string[] parts = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

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
=======
                Console.Write(n + " ");
            }
            Console.WriteLine();

            numbers.Sort();

            Console.WriteLine();

            numbers.Reverse();

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
=======
            Console.WriteLine("Danh sách sau khi đảo ngược:");
            foreach (int n in numbers)
            {
                Console.Write(n + " ");
=======
            Console.WriteLine("Danh sách sau khi sắp xếp tăng dần:");
            foreach (int n in numbers)
            {
                Console.Write(n + " ");
=======
            if (found)
            {
                Console.WriteLine("Chuỗi tồn tại trong danh sách.");
            }
            else
            {
                Console.WriteLine("Chuỗi không tồn tại trong danh sách.");
=======
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
                Console.WriteLine("\nBạn chưa nhập số hợp lệ nào!");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}