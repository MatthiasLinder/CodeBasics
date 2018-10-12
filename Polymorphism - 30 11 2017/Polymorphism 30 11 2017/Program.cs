using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_30_11_2017
{
    class Program
    {
        static void Main(string[] args)
        {
            var shape1 = new Shape();
            shape1.x = 10;
            shape1.y = 20;
            shape1.height = 100;
            shape1.width = 50;
            //shape1.Draw();

            var circle1 = new Circle1();
            circle1.x = 20;
            circle1.y = 10;
            circle1.height = 100;
            circle1.width = 300;
            //circle1.Draw();

            var square = new Square();
            square.x = 20;
            square.y = 20;
            square.height = 20;
            square.width = 20;
            //square.Draw();

            var rectangle = new Rectangle();
            rectangle.x = 20;
            rectangle.y = 40;
            rectangle.height = 20;
            rectangle.width = 40;
            //rectangle.Draw();

            var triangle = new Triangle();
            triangle.x = 40;
            triangle.y = 40;
            triangle.height = 80;
            triangle.width = 40;
            //triangle.Draw();

            var shapes = new List<Shape>();
            shapes.Add(shape1);
            shapes.Add(circle1);
            shapes.Add(square);
            shapes.Add(rectangle);
            shapes.Add(triangle);

            foreach(var i in shapes)
            {
                i.Draw();
            }

            Console.ReadLine();
            











        }
    }
}
