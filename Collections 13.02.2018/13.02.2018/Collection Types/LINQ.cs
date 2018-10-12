using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._02._2018.Collection_Types
{
    class LINQ
    {
        public void LINQ_Collection()
        {
            #region LINQ

            int[] numbers = new int[7] { 0, 1, 2, 3, 4, 5, 6 };

            //var evenNumQuery = from num in numbers
            //               where (num % 2) == 0
            //               select num;
            //int evenNumCount = evenNumQuery.Count();

            var evenNumQuery = from num in numbers
                               where (num % 2) == 0
                               select num;
            int evenNumCount = evenNumQuery.Count();


            #endregion

            #region LINQ Example
            var Humans = new List<Human>
            {
                new Human(){Name = "Kalle", Age = 40},
                new Human(){Name = "Malle", Age = 25},
                new Human(){Name = "Juku", Age = 20},
                new Human(){Name = "Eduard", Age = 35},
                new Human(){Name = "Mari", Age = 20},
                new Human(){Name = "Elmar", Age = 40},
            };

            var g = Humans.Where(x => x.Name == "Kalle").FirstOrDefault().Name;
            var h = Humans.Where(x => x.Age == 40).ToList();
            var i = Humans.Where(x => x.Name.Contains("a")).ToList();
            var j = Humans.Where(x => x.Name.StartsWith("M")).ToList();
            //foreach(var item in i)
            //{
            //    Console.WriteLine(item.Name + " " + item.Age);
            //}

            Console.WriteLine(g);
            foreach (var item in h)
            {
                Console.WriteLine(item.Name + " " + item.Age);
            }

            ////var query = (from element in Humans
            ////             orderby element.Age descending
            ////             where element.Age > 20
            ////             select element).ToList();

            ////foreach(var item in query)
            ////{
            ////    Console.WriteLine(item.Name + " " + item.Age);
            ////}

            //var a = numbers.Contains(4);
            //var a = numbers.ElementAtOrDefault(15);
            var a = numbers.FirstOrDefault();
            var b = false;
            var c = numbers.Take(3).ToList();
            var d = numbers.Average();
            var e = numbers.Max();
            var f = numbers.Min();

            foreach (var item in numbers)
            {
                if (item == 6)
                    b = true;
            }

            foreach (var item in c)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(a);
            Console.WriteLine(b);

            #endregion
        }
    }
}
