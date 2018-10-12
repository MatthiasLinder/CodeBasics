using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._02._2018.Collection_Types
{
    class Queue
    {
        public void Queues()
        {
            #region Queue - First in, First out

            Console.WriteLine("QUEUE:");
            Queue<string> Numbers = new Queue<string>();
            Numbers.Enqueue("One");
            Numbers.Enqueue("Two");
            Numbers.Enqueue("Three");
            Numbers.Enqueue("Four");
            Numbers.Enqueue("Five");

            //We ask for the elements from the Queue
            foreach (string number in Numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("");

            //Take out the first element
            Console.WriteLine("Dequeuing '{0}'", Numbers.Dequeue());
            //Peek at the next element
            Console.WriteLine("Peek at next item to dequeue: {0}", Numbers.Peek());
            //Take out the next element
            Console.WriteLine("Dequeuing '{0}'", Numbers.Dequeue());

            //Make a copy of the list order
            Queue<string> queueCopy = new Queue<string>(Numbers.ToArray());
            Console.WriteLine("Contents of the first Copy:");
            foreach (string number in queueCopy)
            {
                Console.WriteLine(number);
            }

            string[] array2 = new string[Numbers.Count * 2];
            Numbers.CopyTo(array2, Numbers.Count);
            foreach (var item in array2)
            {
                Console.WriteLine(item);
            }

            Queue<string> QueueCopy2 = new Queue<string>(array2);
            Console.WriteLine();
            foreach (string number in QueueCopy2)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("\n queueCopy contains 'four' = {0}", queueCopy.Contains("four"));

            //Empty the Queue
            queueCopy.Clear();
            Console.WriteLine("\n queueCopy count is {0}", queueCopy.Count);


            #endregion
        }
    }
}
