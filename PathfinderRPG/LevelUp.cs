using System.Collections.Generic;

namespace PathfinderRPG
{
    public class LevelUp
    {
        public int Level { get; protected set; }

        public Dictionary<string, int> Stats { get; protected set; }
        public List<string> Abilities { get; protected set; }
        public Dictionary<int, int> SpellsKnown { get; protected set; }
        public Dictionary<int, int> SpellsPerDay { get; protected set; }

        public LevelUp(int level, int baseAttackBonus, int fortSave, int refSave, int willSave)
        {
            Level = level;

            Stats = new Dictionary<string, int>();
            Stats.Add("Base Attack Bonus", baseAttackBonus);
            Stats.Add(GameCodex.SAVE_FORT, fortSave);
            Stats.Add(GameCodex.SAVE_REF, refSave);
            Stats.Add(GameCodex.SAVE_WILL, willSave);

            Abilities = new List<string>();
            SpellsKnown = new Dictionary<int, int>();
            SpellsPerDay = new Dictionary<int, int>();
        }
    }
}