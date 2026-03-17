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
            Console.WriteLine("Đề bài: Nhập ID, xóa sinh viên có ID đó khỏi danh sách.");
            Console.WriteLine("------------------------------");

            List<Student> students = new List<Student>
            {
                new Student { Id = 1, Name = "Nguyễn Văn An" },
                new Student { Id = 2, Name = "Trần Thị Bình" },
                new Student { Id = 3, Name = "Lê Văn Chiến" }
            };

            Console.WriteLine("Danh sách ban đầu:");
            foreach (Student s in students)
            {
                Console.WriteLine("ID: " + s.Id + " | Name: " + s.Name);
            }

            Console.Write("Nhập ID cần xóa: ");
            string input = Console.ReadLine();
            int idToDelete;

            if (!int.TryParse(input, out idToDelete))
            {
                Console.WriteLine("ID không hợp lệ.");
                Console.ReadKey();
                return;
            }

            Student studentToDelete = null;

            foreach (Student s in students)
            {
                if (s.Id == idToDelete)
                {
                    studentToDelete = s;
                    break;
                }
            }

            if (studentToDelete != null)
            {
                students.Remove(studentToDelete);
                Console.WriteLine("Đã xóa sinh viên có ID = " + idToDelete);
            }
            else
            {
                Console.WriteLine("Không tìm thấy sinh viên có ID đó.");
            }

            Console.WriteLine("Danh sách sau khi xóa:");
            foreach (Student s in students)
            {
                Console.WriteLine("ID: " + s.Id + " | Name: " + s.Name);
            }

            Console.ReadKey();
        }
    }
}