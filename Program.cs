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
            Console.WriteLine("Đề bài: Tạo Dictionary<string, string>, lưu từ điển Anh - Việt và tra nghĩa.");
            Console.WriteLine("------------------------------");

            Dictionary<string, string> dictionary = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            dictionary.Add("hello", "xin chào");
            dictionary.Add("book", "quyển sách");
            dictionary.Add("computer", "máy tính");
            dictionary.Add("student", "sinh viên");
            dictionary.Add("school", "trường học");

            Console.Write("Nhập từ tiếng Anh cần tra: ");
            string word = Console.ReadLine();

            if (!string.IsNullOrEmpty(word) && dictionary.ContainsKey(word))
            {
                Console.WriteLine("Nghĩa tiếng Việt: " + dictionary[word]);
            }
            else
            {
                Console.WriteLine("Không tìm thấy từ trong từ điển.");
            }

            Console.ReadKey();
        }
    }
}