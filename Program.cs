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

            Console.Clear();


            Console.WriteLine("Now you are adding some book!");

            Console.WriteLine("Write a title of book:");
            string title1 = Console.ReadLine();

            Console.WriteLine("Write a author of book:");
            string author1 = Console.ReadLine();

            Console.WriteLine("Write a content of book:");
            string content1 = Console.ReadLine();

            Book book = new Book()
            {
                author = new Author() { author = author1 },
                content = new Content() { content = content1 },
                title = new Title() { title = title1 }
            };

            Console.WriteLine("Book:");
            Console.ForegroundColor = ConsoleColor.Red;
            book.title.Show();
            Console.ForegroundColor = ConsoleColor.Blue;
            book.author.Show();
            Console.ForegroundColor = ConsoleColor.Yellow;
            book.content.Show();
            Console.WriteLine("Please click to some button to continue");
            Console.ReadKey();
            Console.Clear();
            Programer pr = new Programer();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Click\n1 to eat\n2 to sleep\n3 to code:");
            int chs = Convert.ToInt32(Console.ReadKey().KeyChar.ToString());
            switch (chs)
            {
                case 1:
                    pr.eat();
                    break;
                case 2:
                    pr.sleep();
                    break;
                case 3:
                    pr.code();
                    break;
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
    class Programer
    {
        public void sleep()
        {
            Console.WriteLine("I'm sleeping don't worry me!");
        }
        public void eat()
        {
            Console.WriteLine("I'm eating don't worry me!");
        }
        public void code()
        {
            Console.WriteLine("I'm coding don't worry me!");
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
        public Author author { get; set; }
        public Title title { get; set; }
        public Content content { get; set; }
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
