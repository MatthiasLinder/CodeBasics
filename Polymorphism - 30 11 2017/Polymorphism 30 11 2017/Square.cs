using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_30_11_2017
{
        public class Square : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Drawing square");
                base.Draw();
            }
        }
}
