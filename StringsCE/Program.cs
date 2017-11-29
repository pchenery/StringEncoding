using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsCE
{
    class Program
    {
        static Book book = new Book();
        static List<Book> books = new List<Book>();

        static void Main(string[] args)
        {
            using (var reader = new StreamReader(@"c:\work\training\stringsce\books.txt"))
            {
                string headerLine = reader.ReadLine();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    DateTime dt;
                    bool success = DateTime.TryParse(values[0], out dt);

                    books.Add (new Book() {
                        Published = dt,
                        Title = values[1],
                        Authors = values[2]
                    });
                }
            }
            CreateTextFile();
        }
        static void CreateTextFile()
        {
            string path = @"c:\work\training\stringsce\books.dat";
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("| Pub Date    |                       Title | Authors                         |");
                    sw.WriteLine("| ============|=============================|=================================|");
                    foreach (var book in books)
                    {
                        sw.WriteLine("| " + book.Published.ToString("d MMM yyy") + " | " + book.Title.PadLeft(27) + " | " + book.Authors.PadRight(31) + " |");
                    }
                }
            }
        }
    }
}
