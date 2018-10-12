using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCombatClasses_30._01._2018
{
    abstract class HostileNPC
    {
        protected string Name;
        protected int Health;
        protected int Damage;
        protected bool Ranged;
        protected int LoopControl = 0;
            
        public virtual int Attack(int PlayerHealth)
        {
            while (LoopControl == 0)
            {
                Random RandomNumbers = new Random();
                int AttackChooser = RandomNumbers.Next(1, 4);
                if (AttackChooser >= 3)
                {
                    if (Ranged == false)
                    {
                        Console.WriteLine(Name + " attacked you dealing " + Damage + " Damage.");
                        Console.WriteLine(Name + " has " + Health + " HP left.");
                                                Ranged = true;
                        return PlayerHealth - Damage;
                    }
                    if (Ranged == true)
                    {
                        int RangedAttack = RandomNumbers.Next(1, 10);
                        if (RangedAttack <= 3)
                        {
                            Console.WriteLine(Name + " attacked you and missed.");
                            Console.WriteLine(Name + " has " + Health + " HP left.");
                            Ranged = false;
                            return PlayerHealth;
                        }
                        if (RangedAttack >= 4)
                        {
                            Console.WriteLine(Name + " threw a spear at you dealing " + (Damage * 2) + " Damage.");
                            Console.WriteLine(Name + " has " + Health + " HP left.");
                            Ranged = false;
                            return PlayerHealth - (Damage * 2);
                        }
                    }
                }
                else if (AttackChooser <= 2)
                {
                    if (Ranged == false)
                    {
                        Console.WriteLine(Name + " attacked you dealing " + (Damage * 2) + " Damage.");
                        Console.WriteLine(Name + " has " + Health + " HP left.");
                        Ranged = true;
                        return PlayerHealth - (Damage * 2);
                    }
                    if (Ranged == true)
                    {
                        int RangedAttack = RandomNumbers.Next(1, 10);
                        if (RangedAttack <= 5)
                        {
                            Console.WriteLine(Name + " attacked you and missed.");
                            Console.WriteLine(Name + " has " + Health + " HP left.");
                            Ranged = false;
                            return PlayerHealth;
                        }
                        if (RangedAttack >= 6)
                        {
                            Console.WriteLine(Name + " threw a spear at you dealing " + (Damage * 3) + " Damage.");
                            Console.WriteLine(Name + " has " + Health + " HP left.");
                            Ranged = false;
                            return PlayerHealth - (Damage * 3);
                        }
                    }
                }
                if (PlayerHealth <= 0)
                {
                    break;
                }
                return PlayerHealth;
            }
            return PlayerHealth;
        }

        public abstract int SpecialAttack();
    }
}
