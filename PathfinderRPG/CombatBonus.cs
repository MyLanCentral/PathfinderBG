using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathfinderRPG
{
    public abstract class CombatBonus
    {
        public string BonusType { get; protected set; }
        public int Modifier { get; protected set; } 
    }
}
