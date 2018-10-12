using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCombatClasses_30._01._2018
{
    class Program
    {
        static void Main(string[] args)
        {
            var PlayerHealth = 1000;
            var BlackKnight = new BlackKnight();
            while (PlayerHealth >= 1)
            {
                Console.WriteLine("--------------------------------------------------------------------------------------");
                Console.WriteLine("");
                PlayerHealth = BlackKnight.Attack(PlayerHealth);
                Console.WriteLine("Your health is at " + PlayerHealth);
                Console.ReadLine();
                Console.Clear();
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("YOU... ARE... DEAD...");
            Console.WriteLine("");
            Console.WriteLine("You can press any key to cast off the humiliation. :3");
        }
    }
}
