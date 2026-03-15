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
=======
            Console.WriteLine("Bài 04: Tạo List<int>, đếm bao nhiêu số chẵn\n");

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
=======
            Console.WriteLine("Nhập các số nguyên (cách nhau bởi khoảng trắng). Ví dụ: 2 5 8 11 14 7");
            Console.Write("Nhập: ");
            string input = Console.ReadLine() ?? "";

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
                if (int.TryParse(p, out int n))
                    ds.Add(n);
            }

            if (ds.Count == 0)
            {
                Console.WriteLine("\nBạn chưa nhập số hợp lệ nào!");
            }
            else
            {
                int tong = 0;
                foreach (int x in ds) tong += x;

                Console.WriteLine("\nDanh sách đã nhập: " + string.Join(" ", ds));
                Console.WriteLine("Tổng các phần tử = " + tong);
            }
=======
            Console.WriteLine("Bài 01: Tạo List<int>, nhập 5 số và in ra màn hình\n");

            List<int> ds = new List<int>();

            for (int i = 1; i <= 5; i++)
            {
                while (true)
                {
                    Console.Write($"Nhập số nguyên thứ {i}: ");
                    string s = Console.ReadLine() ?? "";

                    if (int.TryParse(s, out int n))
                    {
                        ds.Add(n);
                        break;
                    }

                    Console.WriteLine("Bạn nhập sai! Vui lòng nhập lại số nguyên.\n");
                }
            }

            Console.WriteLine("\nCác phần tử trong danh sách:");
            Console.WriteLine(string.Join(" ", ds));

            Console.WriteLine("\nNhấn Enter để kết thúc...");
            Console.ReadLine();
        }
    }
}