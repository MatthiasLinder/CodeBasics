using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._02._2018.Collection_Types
{
    class List
    {
        public void Lists()
        {
            #region List

            //==============================================================//

            var Cars_FirstExample = new List<string>();

            var Car1 = "BMW";
            var Car2 = "Lada";
            var Car3 = "Mercedes";
            var Car4 = "Volkswagen";
            var Car5 = "Subaru";

            Cars_FirstExample.Add(Car1);
            Cars_FirstExample.Add(Car2);
            Cars_FirstExample.Add(Car3);
            Cars_FirstExample.Add(Car4);
            Cars_FirstExample.Add(Car5);

            Cars_FirstExample.Add("Mercedes");
            Cars_FirstExample.Add("Subaru");
            Cars_FirstExample.Add("Lada");

            foreach (var item in Cars_FirstExample)
            {
                Console.WriteLine(item);
            }

            //==============================================================//

            var Cars_SecondExample = new List<string> { "BMW", "Lada", "Mercedes", "Ferrari" };

            Cars_SecondExample.Remove("Ferrari");
            Cars_SecondExample.RemoveAt(1);

            for (int index = 0; index < Cars_SecondExample.Count; index++)
            {
                Console.WriteLine(Cars_SecondExample[index]);

            }

            //==============================================================//

            var Humans = new List<Human>()
            {

            };

            int User = 1;
            int Determinant = 0;
            while (User == 1)
            {
                Console.WriteLine("If you want to enter another name, enter 1. If you want to print the list, enter 2.");
                Determinant = int.Parse(Console.ReadLine());
                if (Determinant == 1)
                {
                    Console.WriteLine("Please enter the person's name.");
                    var AnotherHuman = new Human();
                    AnotherHuman.Name = Console.ReadLine();
                    Console.WriteLine("Please enter the person's age.");
                    AnotherHuman.Age = int.Parse(Console.ReadLine());
                    Humans.Add(AnotherHuman);
                    Console.Clear();
                }
                if (Determinant == 2)
                {
                    foreach (var item in Humans)
                    {
                        Console.WriteLine(item.Name + " is " + item.Age + " Years old");
                        Console.Clear();
                    }
                }
            }

            //==============================================================//

            #endregion
        }
    }
}
