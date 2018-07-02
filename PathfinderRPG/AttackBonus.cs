using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathfinderRPG
{
    public class AttackBonus : CombatBonus
    {
        public string AttackType { get; protected set; }
        public List<string> CreatureTypes { get; protected set; }
        public List<string> CreatureSubtypes { get; protected set; }

        public AttackBonus(string attackType, int modifier)
        {
            BonusType = "Attack Bonus";
            AttackType = attackType;
            Modifier = modifier;

            CreatureTypes = new List<string>();
            CreatureSubtypes = new List<string>();
        }

        public void AddCreatureType(string type)
        {
            if (CreatureTypes.Count == 0)
            {
                CreatureTypes.Add(type);
                return;
            }
            else
            {
                foreach (string creatureType in CreatureTypes)
                {
                    if (creatureType == type)
                    {
                        return;
                    }
                }

                CreatureTypes.Add(type);
                return;
            }
        }
        public void AddCreatureSubtype(string subtype)
        {
            if (CreatureSubtypes.Count == 0)
            {
                CreatureSubtypes.Add(subtype);
                return;
            }
            else
            {
                foreach (string creatureSubtype in CreatureSubtypes)
                {
                    if (creatureSubtype == subtype)
                    {
                        return;
                    }
                }

                CreatureSubtypes.Add(subtype);
                return;
            }
        }
        public void RemoveCreatureType(string type)
        {
            CreatureTypes.Remove(type);
        }
        public void RemoveCreatureSubtype(string subtype)
        {
            CreatureSubtypes.Remove(subtype);
        }
    }
}
