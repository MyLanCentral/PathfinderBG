using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathfinderRPG
{
    public class PlayerClass
    {
        public string ShortName { get; protected set; }
        public string LongName { get; protected set; }
        public int Level { get; protected set; }

        public bool IsCaster { get; protected set; }
        public string CasterType { get; protected set; }

        public int SkillRanksPerLevel { get; protected set; }
        public int HitDie { get; protected set; }
        public List<string> AllowedAlignments { get; protected set; }
        public List<string> ClassSkills { get; protected set; }

        public Dictionary<string, int> BaseStats { get; protected set; }
        public Dictionary<int, int> SpellsPerDay { get; protected set; }
        public Dictionary<int, int> SpellsKnown { get; protected set; }
        public Dictionary<int, LevelUp> LevelTable { get; protected set; }

        public List<string> UsableEquipment { get; protected set; }

        public List<string> Abilities { get; protected set; }

        public PlayerClass(string shortName, string longName)
        {
            ShortName = shortName;
            LongName = longName;

            Initialize();
        }

        private void Initialize()
        {
            Level = 1;

            IsCaster = false;
            CasterType = "";

            SkillRanksPerLevel = 2;
            HitDie = 4;

            AllowedAlignments = new List<string>();
            ClassSkills = new List<string>();

            BaseStats = new Dictionary<string, int>();
            BaseStats.Add("Base Attack Bonus", 0);
            BaseStats.Add(GameCodex.SAVE_FORT, 0);
            BaseStats.Add(GameCodex.SAVE_REF, 0);
            BaseStats.Add(GameCodex.SAVE_WILL, 0);

            SpellsPerDay = new Dictionary<int, int>();
            SpellsKnown = new Dictionary<int, int>();
            LevelTable = new Dictionary<int, LevelUp>();

            UsableEquipment = new List<string>();
            Abilities = new List<string>();
        }

        /// <summary>
        /// Instantly level up to the level specified
        /// </summary>
        /// <param name="newLevel">Level to Move To (must be higher than current level)</param>
        public void LevelUp(int newLevel)
        {

        }

        /// <summary>
        /// Proceed to the next level
        /// </summary>
        public void LevelUp()
        {

        }
    }
}
