using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathfinderRPG
{
    public class PlayerCharacter : IEntity
    {
        public string Name { get; protected set; }
        public string Alignment { get; protected set; }
        public List<PlayerClass> Classes { get; protected set; }
        public PlayerRace Race { get; protected set; }
        public string Deity { get; protected set; }
        public string Homeland { get; protected set; }
        public string Size { get; protected set; }
        public string Gender { get; protected set; }
        public int Age { get; protected set; }
        public int[] Height { get; protected set; }
        public int Weight { get; protected set; }
        public string HairColor { get; protected set; }
        public string EyeColor { get; protected set; }

        public int HealthCurrent { get; protected set; }
        public int HealthMaximum { get; protected set; }
        public int CarryLimit { get; protected set; }

        public Dictionary<string, int> Currency { get; protected set; }
        public Dictionary<string, int> Stats { get; protected set; }
        public Dictionary<string, int> Saves { get; protected set; }
        public Dictionary<string, int> Defenses { get; protected set; }
        public Dictionary<string, int> Skills { get; protected set; }
        public Dictionary<string, Equipment> Equipped { get; protected set; }
        public Dictionary<int, int> SpellsKnown { get; protected set; }
        public Dictionary<int, int> SpellsAvailable { get; protected set; }
        public List<Spell> Spellbook { get; protected set; }
        public List<Ability> Abilities { get; protected set; }
        public List<string> KnownLanguages { get; protected set; }
        public List<CombatBonus> CombatBonuses { get; protected set; }

        public PlayerCharacter()
        {
            Initialize();
        }

        public void Initialize()
        {
            Name = "Stan HeroGuy";
            Alignment = GameCodex.ATN;
            Classes = new List<PlayerClass>();
            Race = null;
            Deity = "None";
            Homeland = "None";
            Size = "Medium";
            Gender = "Male";
            Age = 21;
            Height = new int[] { 5, 6 };
            Weight = 135;
            HairColor = "Brown";
            EyeColor = "Brown";

            HealthMaximum = 10;
            HealthCurrent = HealthMaximum;
            CarryLimit = 70;

            Currency = new Dictionary<string, int>();
            Stats = new Dictionary<string, int>();
            Saves = new Dictionary<string, int>();
            Defenses = new Dictionary<string, int>();
            Skills = new Dictionary<string, int>();
            Equipped = new Dictionary<string, Equipment>();
            SpellsKnown = new Dictionary<int, int>();
            SpellsAvailable = new Dictionary<int, int>();
            Spellbook = new List<Spell>();
            Abilities = new List<Ability>();
            KnownLanguages = new List<string>();
            CombatBonuses = new List<CombatBonus>();
        }

        public PlayerCharacter(string name, string alignment, List<PlayerClass> classes, PlayerRace race, string deity, string homeland, string size,
            string gender, int age, int[] height, int weight, string hairColor, string eyeColor, int healthMaximum, int healthCurrent, int carryLimit,
            Dictionary<string,int> currency, Dictionary<string, int> stats, Dictionary<string,int> saves, Dictionary<string,int> defenses, Dictionary<string,int> skills,
            Dictionary<string, Equipment> equipped, Dictionary<int,int> spellsKnown, Dictionary<int,int> spellsAvailable, List<Spell> spellbook, List<Ability> abilities,
            List<string> knownLanguages, List<CombatBonus> combatBonuses)
        {
            Name = name;
            Alignment = alignment;
            Classes = new List<PlayerClass>(classes);
            Race = race;
            Deity = deity;
            Homeland = homeland;
            Size = size;
            Gender = gender;
            Age = age;
            Height = height;
            Weight = weight;
            HairColor = hairColor;
            EyeColor = eyeColor;

            HealthMaximum = healthMaximum;
            HealthCurrent = healthCurrent;
            CarryLimit = carryLimit;

            Currency = new Dictionary<string, int>(currency);
            Stats = new Dictionary<string, int>(stats);
            Saves = new Dictionary<string, int>(saves);
            Defenses = new Dictionary<string, int>(defenses);
            Skills = new Dictionary<string, int>(skills);
            Equipped = new Dictionary<string, Equipment>(equipped);
            SpellsKnown = new Dictionary<int, int>(spellsKnown);
            SpellsAvailable = new Dictionary<int, int>(spellsAvailable);
            Spellbook = new List<Spell>(spellbook);
            Abilities = new List<Ability>(abilities);
            KnownLanguages = new List<string>(knownLanguages);
            CombatBonuses = new List<CombatBonus>(combatBonuses);
        }

        public void CalculateStats()
        {

        }
    }
}
