using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._02._2018
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Array

            //int[] minuArvud = new int[5];
            //minuArvud[0] = 10;
            //minuArvud[1] = 12;
            //minuArvud[2] = 3;
            //minuArvud[3] = 5;
            //minuArvud[4] = 1;

            //List<int> minuArvudListis = new List<int>();
            //minuArvudListis.Add(1); //index = 0
            //minuArvudListis.Add(2); //index = 1
            //minuArvudListis.Add(3); //index = 2
            //minuArvudListis.Add(4); //index = 3
            //minuArvudListis.Add(5);
            //minuArvudListis.Add(6);
            //minuArvudListis.Add(7);

            //foreach(int OneNumber in minuArvudListis)
            //{
            //    Console.WriteLine(OneNumber);
            //}

            //int NewInt = 18;
            //minuArvudListis.Insert(3, NewInt);
            //minuArvudListis.Add(8);

            //List<Human> MyHumansInAList = new List<Human>
            //{
            //    new Human{Name = "Priit" }
            //};
            //Human FirstHuman = new Human();
            //FirstHuman.Name = "Priit";
            //FirstHuman.Age = 25;

            //Human SecondHuman = new Human();
            //FirstHuman.Name = "Adolf";
            //FirstHuman.Age = 25;


            //MyHumansInAList.Add(FirstHuman);

            //foreach(Human Human in MyHumansInAList)
            //{

            //}

            //GRUPEERIMINE

            ////var humans1 = new List<Human>
            ////{
            ////    new Human() {Name = "Kalle", Age = 15},
            ////    new Human() { Name = "Malle", Age = 18 },
            ////    new Human() { Name = "Tõnu", Age = 25 },
            ////    new Human() { Name = "Aadu", Age = 55 },
            ////    new Human() { Name = "Heimar", Age = 95 },
            ////    new Human() { Name = "Jossi", Age = 5 },
            ////    new Human() { Name = "Piero", Age = 40 },
            ////    new Human() { Name = "Susanna", Age = 15 },
            ////};

            ////int[] numbers = new int[8] { 0, 1, 2, 3, 4, 5, 6, 5 };

            //////var grupid = from Human in humans1
            //////             group human by human.Age == 40

            ////var grupid = from human in humans1
            ////             group human by human.Age into newGroup
            ////             select newGroup;

            ////foreach(var grupp in grupid)
            ////{
            ////    Console.WriteLine("");
            ////    Console.WriteLine("Uus grupp.");
            ////    foreach(var item in grupp)
            ////    {
            ////        Console.WriteLine(item.Age + " " + item.Name);
            ////    }
            ////}

            ////var firstLetterGroup =
            ////    from human in humans1
            ////    group human by human.Name[0];

            ////foreach (var humanGroup in firstLetterGroup)
            ////{
            ////    Console.WriteLine("Key:" + humanGroup.Key);
            ////    foreach(var human in humanGroup)
            ////    {
            ////        Console.WriteLine(human.Name + " " + human.Age);
            ////    }
            ////}

            var humans1 = new List<Human>
            {
                new Human() {Name = "Kalle", Age = 15},
                new Human() { Name = "Malle", Age = 18 },
                new Human() { Name = "Tõnu", Age = 25 },
                new Human() { Name = "Aadu", Age = 55 },
                new Human() { Name = "Heimar", Age = 95 },
                new Human() { Name = "Jossi", Age = 5 },
                new Human() { Name = "Piero", Age = 40 },
                new Human() { Name = "Susanna", Age = 15 },
            };

            var grupid = from human in humans1
                         group human by human.Name.Length into newGroup
                         select newGroup;

            

            foreach (var humanGroup in grupid)
            {
                Console.WriteLine("");
                Console.WriteLine("Key:" + humanGroup.Key);
                Console.WriteLine("Count:" + humanGroup.Count());
                foreach (var human in humanGroup)
                {
                    Console.WriteLine(human.Name + " " + human.Name.Length);
                    if(human.Name.Length % 2 == 0)
                    {
                        Console.WriteLine("EVEN AMOUNT OF LETTERS ");
                        Console.WriteLine("");
                    }
                }
            }
            Console.WriteLine("");
            Console.WriteLine("");

            foreach (var humanGroup in grupid)
            {
                foreach (var human in humanGroup)
                {
                    if (human.Name.Length % 2 == 0)
                    {
                        Console.WriteLine("EVEN " + human.Name + " with a letter amount of " + human.Name.Length);
                        
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
