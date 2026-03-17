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
            Console.WriteLine("Tên: Dương Phước Quang");
            Console.WriteLine("MSV: 2415053122131");
            Console.WriteLine("Đề bài: Tạo class Student, lưu danh sách sinh viên trong List<Student> và in thông tin.");
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

            Console.ReadKey();
        }
    }
}