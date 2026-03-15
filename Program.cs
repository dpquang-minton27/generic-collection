using System;
using System.Collections.Generic;
using System.Text;

namespace generic_collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Console.WriteLine("SV: Dương Phước Quang - MSSV: 2415053122131");
            Console.WriteLine("Bài 05: Tạo List<string> tên sinh viên, xóa một tên do người dùng nhập\n");

            int n;
            Console.Write("Nhập số lượng sinh viên: ");
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.Write("Nhập lại số lượng (số nguyên > 0): ");
            }

            List<string> dsTen = new List<string>();
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Nhập tên sinh viên {i}: ");
                string ten = (Console.ReadLine() ?? "").Trim();

                while (ten == "")
                {
                    Console.Write("Tên không được rỗng, nhập lại: ");
                    ten = (Console.ReadLine() ?? "").Trim();
                }

                dsTen.Add(ten);
            }

            Console.WriteLine("\nDanh sách ban đầu:");
            Console.WriteLine(string.Join(", ", dsTen));

            Console.Write("\nNhập tên cần xóa: ");
            string tenXoa = (Console.ReadLine() ?? "").Trim();

            int truoc = dsTen.Count;

            dsTen.RemoveAll(t => string.Equals(t, tenXoa, StringComparison.OrdinalIgnoreCase));

            if (dsTen.Count < truoc)
            {
                Console.WriteLine("\nĐã xóa thành công!");
                Console.WriteLine("Danh sách sau khi xóa:");
                Console.WriteLine(string.Join(", ", dsTen));
            }
            else
            {
                Console.WriteLine("\nKhông tìm thấy tên cần xóa!");
            }

            Console.WriteLine("\nNhấn Enter để kết thúc...");
            Console.ReadLine();
        }
    }
}