using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_30_11_2017
{
    public class Shape
    {
        public int x { get; set; }
        public int y { get; set; }
        public int height { get; set; }
        public int width { get; set; }


        public virtual void Draw()
        {
            Console.WriteLine("Preforming base class drawing tasks");
        }
    }
}
