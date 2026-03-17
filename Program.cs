using System;
using System.Collections.Generic;
using System.Text;

namespace generic_collection
{
    class Student
    {
        public string Name;
        public double Score;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Console.WriteLine("Tên: Dương Phước Quang");
            Console.WriteLine("MSV: 2415053122131");
            Console.WriteLine("Đề bài: Tạo class Student, lưu danh sách trong List<Student> và in sinh viên có điểm cao nhất.");
            Console.WriteLine("------------------------------");

            List<Student> students = new List<Student>
            {
                new Student { Name = "Nguyễn Văn An", Score = 8.5 },
                new Student { Name = "Trần Thị Bình", Score = 9.2 },
                new Student { Name = "Lê Văn Chiến", Score = 7.8 },
                new Student { Name = "Phạm Thị Dung", Score = 8.9 }
            };

            Console.WriteLine("Danh sách sinh viên:");
            foreach (Student s in students)
            {
                Console.WriteLine("Name: " + s.Name + " | Score: " + s.Score);
            }

            if (students.Count == 0)
            {
                Console.WriteLine("Danh sách sinh viên rỗng.");
                Console.ReadKey();
                return;
            }

            Student bestStudent = students[0];

            for (int i = 1; i < students.Count; i++)
            {
                if (students[i].Score > bestStudent.Score)
                {
                    bestStudent = students[i];
                }
            }

            Console.WriteLine();
            Console.WriteLine("Sinh viên có điểm cao nhất:");
            Console.WriteLine("Name: " + bestStudent.Name + " | Score: " + bestStudent.Score);

            Console.ReadKey();
        }
    }
}