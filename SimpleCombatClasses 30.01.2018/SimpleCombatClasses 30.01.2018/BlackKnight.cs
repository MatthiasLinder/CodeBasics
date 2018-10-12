using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCombatClasses_30._01._2018
{
    class BlackKnight : HostileNPC
    {
        public BlackKnight()
        {
             Name = "Black Knight";
             Health = 100;
             Damage = 15;
             Ranged = true;
        }
        

        public override int SpecialAttack()
        {
            throw new NotImplementedException();
        }


    }
}
