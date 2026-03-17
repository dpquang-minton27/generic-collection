using System;
using System.Collections.Generic;
using System.Text;

namespace generic_collection
{
    class Student
    {
        public int Id;
        public string Name;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Console.WriteLine("Tên: Dương Phước Quang");
            Console.WriteLine("MSV: 2415053122131");
            Console.WriteLine("Đề bài: Từ List<Student>, tìm sinh viên theo tên nhập vào.");
            Console.WriteLine("------------------------------");

            List<Student> students = new List<Student>
            {
                new Student { Id = 1, Name = "Nguyễn Văn An" },
                new Student { Id = 2, Name = "Trần Thị Bình" },
                new Student { Id = 3, Name = "Lê Văn Chiến" }
            };

            Console.WriteLine("Danh sách sinh viên:");
            foreach (Student s in students)
            {
                Console.WriteLine("ID: " + s.Id + " | Name: " + s.Name);
            }

            Console.Write("Nhập tên sinh viên cần tìm: ");
            string keyword = (Console.ReadLine() ?? "").Trim();

            bool found = false;

            foreach (Student s in students)
            {
                if ((s.Name ?? "").Trim().Equals(keyword, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Tìm thấy sinh viên:");
                    Console.WriteLine("ID: " + s.Id + " | Name: " + s.Name);
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("Không tìm thấy sinh viên.");
            }

            Console.ReadKey();
        }
    }
}