using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._02._2018.Collection_Types
{
    class Stack
    {
        public void Stacks()
        {
            #region Stack - Last in, First Out
            Console.WriteLine("STACK:");
            Stack<string> NumbersStack = new Stack<string>();
            NumbersStack.Push("One");
            NumbersStack.Push("Two");
            NumbersStack.Push("Three");
            NumbersStack.Push("Four");
            NumbersStack.Push("Five");

            foreach (string item in NumbersStack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n Popping '{0}'", NumbersStack.Pop());
            Console.WriteLine("Peek at the next item to destack: {0}", NumbersStack.Peek());
            Console.WriteLine("Popping '{0}'", NumbersStack.Pop());

            #endregion
        }
    }
}
