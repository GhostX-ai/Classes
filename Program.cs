using System;
using System.Collections.Generic;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle reg = new Rectangle();
            Console.WriteLine("Enter first side:");
            double s1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second side:");
            double s2 = double.Parse(Console.ReadLine());
            reg.side1 = s1;
            reg.side2 = s2;
            Console.WriteLine($"Area:{reg.Area}\nPerimeter{reg.Perimeter}");

            Console.WriteLine("Click some key to continue");

            Console.ReadKey();

            List<Book> books = new List<Book>();
            List<Title> titles = new List<Title>();
            List<Content> contents = new List<Content>();
            List<Author> authors = new List<Author>();
            x1:
            Console.Clear();
            Console.WriteLine("Books:");
            foreach (var x in books)
            {
                x.Show();
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Titles:");
            foreach (var x in titles)
            {
                x.Show();
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Authors:");
            foreach (var x in authors)
            {
                x.Show();
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Content:");
            foreach (var x in contents)
            {
                x.Show();
            }
            bool w = true;
            Console.WriteLine("Click \n1 to add book\n2 to add title\n3 to add author\n4 to add\n5 to go to next task");
            int ch = int.Parse(Console.ReadKey().KeyChar.ToString());
            Console.ForegroundColor = ConsoleColor.Gray;
            switch (ch)
            {
                case 1:
                    {
                        string bk = EnterValue("Book");
                        books.Add(new Book() { book = bk });
                    }
                    break;
                case 2:
                    {
                        string ttl = EnterValue("Title");
                        titles.Add(new Title() { title = ttl });
                    }
                    break;
                case 3:
                    {
                        string athr = EnterValue("Author");
                        authors.Add(new Author() { author = athr });
                    }
                    break;
                case 4:
                    {
                        string cn = EnterValue("Content");
                        contents.Add(new Content() { content = cn });
                    }
                    break;
                case 5:
                    {
                        w = false;
                    }
                    break;
            }
            if (w)
            {
                goto x1;
            }
            Console.ReadKey();
        }
        public static string EnterValue(string val)
        {
            Console.WriteLine(val + ":");
            string s = Console.ReadLine();
            return s;
        }
    }
    class Rectangle
    {
        public double side1 { get; set; }
        public double side2 { get; set; }
        public double Area { get { return AreaCalculator(); } }
        public double Perimeter { get { return PerimeterCalculator(); } }
        public Rectangle()
        {

        }
        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
        public double AreaCalculator()
        {
            return side1 * side2;
        }
        public double PerimeterCalculator()
        {
            return 2 * (side1 + side2);
        }
    }
    class Book
    {
        public string book { get; set; }
        public void Show()
        {
            Console.WriteLine(this.book);
        }
    }
    class Title
    {
        public string title { get; set; }
        public void Show()
        {
            Console.WriteLine(this.title);
        }
    }
    class Author
    {
        public string author { get; set; }
        public void Show()
        {
            Console.WriteLine(this.author);
        }
    }
    class Content
    {
        public string content { get; set; }
        public void Show()
        {
            Console.WriteLine(this.content);
        }
    }
}
