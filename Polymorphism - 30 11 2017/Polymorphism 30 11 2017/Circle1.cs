using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_30_11_2017
{
    public class Circle1 : Shape
    {
        public override void Draw()
        {

            Console.WriteLine("Drawing circle");
            base.Draw();
        }
    }
}
