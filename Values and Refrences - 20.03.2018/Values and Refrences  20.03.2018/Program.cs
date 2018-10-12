using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Values_and_Refrences__20._03._2018
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point();
            p1.X = 2;
            p1.Y = 3;

            Human h1; //Loome viite
            h1 = new Human(); //Loome objekti
            h1.Age = 12;
            h1.Name = "ABC";

            Point p2 = p1;
            Human h2 = h1;

            p2.X = 23;
            h2.Age = 24;

            //Console.WriteLine("Point X ={0}, y ={1}", p1.X, p1.Y);
            //Console.WriteLine("Point X ={0}, y ={1}", p2.X, p2.Y);
            //Console.WriteLine("Human name = {0}, Age = {1}", h1.Name, h1.Age);
            //Console.WriteLine("Human name = {0}, Age = {1}", h2.Name, h2.Age);

            var Text1 = "Hello World!";
            int Number1 = 12;

            string Text2 = Text1;
            int Number2 = Number1;
            Text2 = "Changed";
            Number2 = 666;

            char[] a = new char[4];
            a[0] = 't';
            a[1] = 'e';
            a[2] = 'r';
            a[3] = 'e';

            Console.WriteLine("Arv1 = {0}, Arv2 = {1}", Number1, Number2);
            Console.WriteLine("Text1 = {0}, Text2 = {1}", Text1, Text2);

            Console.ReadLine();
        }
    }

    struct Point
    {
        private int x, y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }
    }

    public class Human
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }
}
