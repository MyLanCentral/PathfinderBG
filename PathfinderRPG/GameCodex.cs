using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathfinderRPG
{
    public static class GameCodex
    {
        /* LISTS */
        public static readonly List<PlayerClass> Classes = new List<PlayerClass>();
        public static readonly List<PlayerRace> Races = new List<PlayerRace>();


        /* STATIC CONSTANTS */

        // Stat Score Types
        public const string STR = "Strength";
        public const string DEX = "Dexterity";
        public const string CON = "Constitution";
        public const string INT = "Intelligence";
        public const string WIS = "Wisdom";
        public const string CHA = "Charisma";

        // Save Score Types
        public const string SAVE_FORT = "Fortitude";
        public const string SAVE_REF = "Reflex";
        public const string SAVE_WILL = "Will";

        // Sense Types

        public const string SENSE_DARKVISION = "Darkvision";
        public const string SENSE_DIMVISION = "Dimvision";

        // Defense Score Types
        public const string DEFENSE_AC = "Armor Class";
        public const string DEFENSE_FLAT = "Flat-Footed";
        public const string DEFENSE_TOUCH = "Touch";

        // Alignment Types
        public const string ACG = "Chaotic Good";
        public const string ANG = "Neutral Good";
        public const string ALG = "Lawful Good";
        public const string ACN = "Chaotic Neutral";
        public const string ATN = "True Neutral";
        public const string ALN = "Lawful Neutral";
        public const string ACE = "Chaotic Evil";
        public const string ANE = "Neutral Evil";
        public const string ALE = "Lawful Neutral";

        // Size Types
        public const string SIZE_FINE = "Fine";
        public const string SIZE_DIMINUTIVE = "Diminutive";
        public const string SIZE_TINY = "Tiny";
        public const string SIZE_SMALL = "Small";
        public const string SIZE_MEDIUM = "Medium";
        public const string SIZE_LARGE = "Large";
        public const string SIZE_HUGE = "Huge";
        public const string SIZE_GARGANTUAN = "Gargantuan";
        public const string SIZE_COLOSSAL = "Colossal";

        // Skill Shortnames

        public const string SKILL_ACROBATICS = "Acrobatics";
        public const string SKILL_APPRAISE = "Appraise";
        public const string SKILL_BLUFF = "Bluff";
        public const string SKILL_CLIMB = "Climb";
        public const string SKILL_CRAFT = "Craft";
        public const string SKILL_DIPLOMACY = "Diplomacy";
        public const string SKILL_DISABLEDEVICE = "Disable Device";
        public const string SKILL_DISGUISE = "Disguise";
        public const string SKILL_ESCAPEARTIST = "Escape Artist";
        public const string SKILL_FLY = "Fly";
        public const string SKILL_HANDLEANIMAL = "Handle Animal";
        public const string SKILL_HEAL = "Heal";
        public const string SKILL_INTIMIDATE = "Intimidate";
        public const string SKILL_KNOWLEDGE_ARCANA = "Knowledge (Arcana)";
        public const string SKILL_KNOWLEDGE_DUNGEON = "Knowledge (Dungeoneering)";
        public const string SKILL_KNOWLEDGE_ENGINEERING = "Knowledge (Engineering)";
        public const string SKILL_KNOWLEDGE_GEOGRAPHY = "Knowledge (Geography)";
        public const string SKILL_KNOWLEDGE_HISTORY = "Knowledge (History)";
        public const string SKILL_KNOWLEDGE_LOCAL = "Knowledge (Local)";
        public const string SKILL_KNOWLEDGE_NATURE = "Knowledge (Nature)";
        public const string SKILL_KNOWLEDGE_NOBILITY = "Knowledge (Nobility)";
        public const string SKILL_KNOWLEDGE_PLANES = "Knowledge (Planes)";
        public const string SKILL_KNOWLEDGE_RELIGION = "Knowledge (Religion)";
        public const string SKILL_LINGUISTICS = "Linguistics";
        public const string SKILL_PERCEPTION = "Perception";
        public const string SKILL_PERFORM = "Perform";
        public const string SKILL_PROFESSION = "Profession";
        public const string SKILL_RIDE = "Ride";
        public const string SKILL_SENSEMOTIVE = "Sense Motive";
        public const string SKILL_SLEIGHTOFHAND = "Sleight of Hand";
        public const string SKILL_SPELLCRAFT = "Spellcraft";
        public const string SKILL_STEALTH = "Stealth";
        public const string SKILL_SURVIVAL = "Survival";
        public const string SKILL_SWIM = "Swim";
        public const string SKILL_USEMAGICDEVICE = "Use Magic Device";

        // Language ShortNames

        public const string LANG_COMMON = "Common";
        public const string LANG_DWARF = "Dwarven";
        public const string LANG_ELF = "Elven";
        public const string LANG_GNOME = "Gnome";
        public const string LANG_HALFLING = "Halfling";
        public const string LANG_ORC = "Orcish";
        public const string LANG_GIANT = "Giant";
        public const string LANG_GOBLIN = "Goblin";
        public const string LANG_TERRAN = "Terran";
        public const string LANG_UNDERCOMMON = "Undercommon";
        public const string LANG_CELESTIAL = "Celestial";
        public const string LANG_DRAGON = "Draconic";
        public const string LANG_GNOLL = "Gnoll";
        public const string LANG_SYLVAN = "Sylvan";
        public const string LANG_DRUID = "Druidic";
        public const string LANG_ABYSSAL = "Abyssal";

        // Magic Schools

        public const string SCHOOL_ABJURATION = "Abjuration";
        public const string SCHOOL_CONJURATION = "Conjuration";
        public const string SCHOOL_DIVINATION = "Divination";
        public const string SCHOOL_ENCHANTMENT = "Enchantment";
        public const string SCHOOL_EVOCATION = "Evocation";
        public const string SCHOOL_ILLUSION = "Illusion";
        public const string SCHOOL_NECROMANCY = "Necromancy";
        public const string SCHOOL_TRANSMUTATION = "Transmutation";

        // Ability Types

        public const string ABILITY_SPELL = "MagicSpell";
        public const string ABILITY_SPELLLIKE = "Spell-Like Ability";
        public const string ABILITY_POISON = "Poison";

        // Combat Maneuver Attack Types

        public const string ATTACK_GRAPPLE = "Grapple";
        public const string ATTACK_BULLRUSH = "Bull Rush";
        public const string ATTACK_TRIP = "Trip";
        public const string ATTACK_DISARM = "Disarm";

        // Attack Types

        public const string ATTACK_REGULAR = "Vs AC Roll";

        // Creature Types

        public const string CREATURETYPE_ABERRATION = "Aberration";
        public const string CREATURETYPE_ANIMAL = "Animal";
        public const string CREATURETYPE_CONSTRUCT = "Construct";
        public const string CREATURETYPE_DRAGON = "Dragon";
        public const string CREATURETYPE_FEY = "Fey";
        public const string CREATURETYPE_HUMANOID = "Humanoid";
        public const string CREATURETYPE_MAGICALBEAST = "Magical Beast";
        public const string CREATURETYPE_MONSTROUS = "Monstrous Humanoid";
        public const string CREATURETYPE_OOZE = "Ooze";
        public const string CREATURETYPE_OUTSIDER = "Outsider";
        public const string CREATURETYPE_PLANT = "Plant";
        public const string CREATURETYPE_UNDEAD = "Undead";
        public const string CREATURETYPE_VERMIN = "Vermin";

        // Creature Subtypes

        public const string CREATURESUBTYPE_ADLET = "Adlet";
        public const string CREATURESUBTYPE_AEON = "Aeon";
        public const string CREATURESUBTYPE_AETHER = "Aether";
        public const string CREATURESUBTYPE_AGATHION = "Agathion";
        public const string CREATURESUBTYPE_AIR = "Air";
        public const string CREATURESUBTYPE_ANDROID = "Android";
        public const string CREATURESUBTYPE_ANGEL = "Angel";
        public const string CREATURESUBTYPE_AQUATIC = "Aquatic";
        public const string CREATURESUBTYPE_ARCHON = "Archon";
        public const string CREATURESUBTYPE_ASURA = "Asura";
        public const string CREATURESUBTYPE_AUGMENTED = "Augmented";
        public const string CREATURESUBTYPE_AZATA = "Azata";
        public const string CREATURESUBTYPE_BEHEMOTH = "Behemoth";
        public const string CREATURESUBTYPE_CATFOLK = "Catfolk";
        public const string CREATURESUBTYPE_CHANGELING = "Changeling";
        public const string CREATURESUBTYPE_CHAOTIC = "Chaotic";
        public const string CREATURESUBTYPE_CLOCKWORK = "Clockwork";
        public const string CREATURESUBTYPE_COLD = "Cold";
        public const string CREATURESUBTYPE_COLOSSUS = "Colossus";
        public const string CREATURESUBTYPE_DAEMON = "Daemon";
        public const string CREATURESUBTYPE_DARKFOLK = "Dark Folk";
        public const string CREATURESUBTYPE_DEEPONE = "Deep One";
        public const string CREATURESUBTYPE_DEMODAND = "Demodand";
        public const string CREATURESUBTYPE_DEMON = "Demon";
        public const string CREATURESUBTYPE_DEVIL = "Devil";
        public const string CREATURESUBTYPE_DIV = "Div";
        public const string CREATURESUBTYPE_DWARF = "Dwarf";
        public const string CREATURESUBTYPE_EARTH = "Earth";
        public const string CREATURESUBTYPE_ELEMENTAL = "Elemental";
        public const string CREATURESUBTYPE_ELF = "Elf";
        public const string CREATURESUBTYPE_EVIL = "Evil";
        public const string CREATURESUBTYPE_EXTRAPLANAR = "Extraplanar";
        public const string CREATURESUBTYPE_FIRE = "Fire";
        public const string CREATURESUBTYPE_GIANT = "Giant";
        public const string CREATURESUBTYPE_GNOME = "Gnome";
        public const string CREATURESUBTYPE_GOBLINOID = "Goblinoid";
        public const string CREATURESUBTYPE_GOOD = "Good";
        public const string CREATURESUBTYPE_GRAY = "Gray";
        public const string CREATURESUBTYPE_GREATOLDONE = "Great Old One";
        public const string CREATURESUBTYPE_GRIPPLI = "Grippli";
        public const string CREATURESUBTYPE_HALFLING = "Halfling";
        public const string CREATURESUBTYPE_HUMAN = "Human";
        public const string CREATURESUBTYPE_INCORPOREAL = "Incorporeal";
        public const string CREATURESUBTYPE_INEVITABLE = "Inevitable";
        public const string CREATURESUBTYPE_KAIJU = "Kaiju";
        public const string CREATURESUBTYPE_KAMI = "Kami";
        public const string CREATURESUBTYPE_KASATHA = "Kasatha";
        public const string CREATURESUBTYPE_KITSUNE = "Kitsune";
        public const string CREATURESUBTYPE_KYTON = "Kyton";
        public const string CREATURESUBTYPE_LAWFUL = "Lawful";
        public const string CREATURESUBTYPE_LESHY = "Leshy";
        public const string CREATURESUBTYPE_MANASAPUTRA = "Manasaputra";
        public const string CREATURESUBTYPE_MYTHIC = "Mythic";
        public const string CREATURESUBTYPE_NATIVE = "Native";
        public const string CREATURESUBTYPE_NIGHTSHADE = "Nightshade";
        public const string CREATURESUBTYPE_ONI = "Oni";
        public const string CREATURESUBTYPE_ORC = "Orc";
        public const string CREATURESUBTYPE_PHANTOM = "Phantom";
        public const string CREATURESUBTYPE_PROTEAN = "Protean";
        public const string CREATURESUBTYPE_PSYCHOPOMP = "Psychopomp";
        public const string CREATURESUBTYPE_QLIPPOTH = "Qlippoth";
        public const string CREATURESUBTYPE_RAKSHASA = "Rakshasa";
        public const string CREATURESUBTYPE_RATFOLK = "Ratfolk";
        public const string CREATURESUBTYPE_REPTILIAN = "Reptilian";
        public const string CREATURESUBTYPE_ROBOT = "Robot";
        public const string CREATURESUBTYPE_SAHKIL = "Sahkil";
        public const string CREATURESUBTYPE_SAMSARAN = "Samsaran";
        public const string CREATURESUBTYPE_SASQUATCH = "Sasquatch";
        public const string CREATURESUBTYPE_SHAPECHANGER = "Shapechanger";
        public const string CREATURESUBTYPE_SKINWALKER = "Skinwalker";
        public const string CREATURESUBTYPE_SWARM = "Swarm";
        public const string CREATURESUBTYPE_UDAEUS = "Udaeus";
        public const string CREATURESUBTYPE_VANARA = "Vanara";
        public const string CREATURESUBTYPE_VISHKANYA = "Vishkanya";
        public const string CREATURESUBTYPE_WATER = "Water";
        public const string CREATURESUBTYPE_WAYANG = "Wayang";


        /* STATIC FUNCTIONS */
        public static void GenerateCodex()
        {
            PopulateSkills();
            PopulateSpells();
            PopulateAbilities();
            PopulateItems();
            PopulateEquipment();
            PopulateClasses();
            PopulateRaces();
        }

        public static void PopulateClasses()
        {
            PlayerClass barbarian = new PlayerClass("corebarbarian", "Barbarian");
            
        }

        public static void PopulateRaces()
        {
            // DWARF RACE
            PlayerRace dwarf = new PlayerRace("coredwarf", "Dwarf");
            dwarf.DefineRaceTraits(SIZE_MEDIUM, 20, true);
            dwarf.SetDescriptions("Dwarves are a short and stocky race, and stand about a foot shorter than most humans, with wide, compact bodies that account for their burly appearance. Male and female dwarves pride themselves on the length of their hair, and men often decorate their beards with a variety of clasps and intricate braids. A clean-shaven male dwarf is a sure sign of madness, or worse—no one familiar with their race trusts a beardless dwarf.",
                "The great distances between their mountain citadels account for many of the cultural differences that exist within dwarven society. Despite these schisms, dwarves throughout the world are characterized by their love of stonework, their passion for stone- and metal-based craftsmanship and architecture, and a fierce hatred of giants, orcs, and goblinoids.",
                "Dwarves and orcs have long dwelt in proximity, theirs a history of violence as old as both their races. Dwarves generally distrust and shun half-orcs. They find halflings, elves, and gnomes to be too frail, flighty, or 'pretty' to be worthy of proper respect. It is with humans that dwarves share the strongest link, for humans' industrious nature and hearty appetites come closest to matching those of the dwarven ideal.",
                "Dwarves are driven by honor and tradition, and while they are often satirized as standoffish, they have a strong sense of friendship and justice, and those who win their trust understand that, while they work hard, they play even harder—especially when good ale is involved. Most dwarves are lawful good.",
                "Although dwarven adventurers are rare compared to humans, they can be found in most regions of the world. Dwarves often leave the confines of their redoubts to seek glory for their clans, to find wealth with which to enrich the fortress-homes of their birth, or to reclaim fallen dwarven citadels from racial enemies. Dwarven warfare is often characterized by tunnel fighting and melee combat, and as such most dwarves tend toward classes such as fighters and barbarians.",
                "Dwarves are both tough and wise, but a bit gruff (+2 Con, +2 Wis, -2 Cha)\nDwarves are Medium-sized creatures and have no bonuses or penalties due to their size.\nDwarves have a base speed of 20 feet, but their speed is never modified by armor or encumbrance.\nDwarves can see in the dark up to 60 feet.\nDwarves get a +4 dodge bonus to AC against monsters of the Giant subtype.\nDwarves receive a +2 racial bonus to Appraise.\nDwarves receive a +1 bonus on Attack Rolls made against humanoid creatures of the Goblin and Giant subtypes.\nDwarves receive a +2 bonus to saving throws against poisons, spells, and spell-like abilities.\nDwarves receive a +4 bonus to their Combat Maneuver Defense when resisting bull rush or trip.\nDwarves receive a +2 bonus to Perception against unusual stonework passively.\nDwarves are proficient with battleaxes, heavy picks, warhammers, and treat any weapon with 'dwarven' in its name as a Martial-class weapon.\nDwarves being play speaking Common and Dwarven. Dwarves with higher intelligence can choose from the following additional languages: Giant, Gnome, Goblin, Terran, and Undercommon.");
            dwarf.AddStatModifier(CON, 2);
            dwarf.AddStatModifier(WIS, 2);
            dwarf.AddStatModifier(CHA, -2);
            dwarf.AddSkillBonus(SKILL_APPRAISE, 2);
            dwarf.AddSkillBonus(SKILL_PERCEPTION, 2);
            dwarf.AddSensesModifier(SENSE_DARKVISION, 60);
            dwarf.AddAvailableLanguage(LANG_COMMON);
            dwarf.AddAvailableLanguage(LANG_DWARF);
            dwarf.AddAvailableLanguage(LANG_GIANT);
            dwarf.AddAvailableLanguage(LANG_GNOME);
            dwarf.AddAvailableLanguage(LANG_GOBLIN);
            dwarf.AddAvailableLanguage(LANG_ORC);
            dwarf.AddAvailableLanguage(LANG_TERRAN);
            dwarf.AddAvailableLanguage(LANG_UNDERCOMMON);
            dwarf.AddKnownLanguage(LANG_COMMON);
            dwarf.AddKnownLanguage(LANG_DWARF);
            dwarf.AddUsableEquipment("battleaxe");
            dwarf.AddUsableEquipment("heavypick");
            dwarf.AddUsableEquipment("warhammer");
            dwarf.AddCombatBonus(new CMDBonus(ATTACK_BULLRUSH, 4));
            dwarf.AddCombatBonus(new CMDBonus(ATTACK_TRIP, 4));
            
            AttackBonus dwarfvsgiantbonus = new AttackBonus(ATTACK_REGULAR, 1);
            dwarfvsgiantbonus.AddCreatureSubtype(CREATURESUBTYPE_GIANT);
            dwarfvsgiantbonus.AddCreatureSubtype(CREATURESUBTYPE_GOBLINOID);
            dwarf.AddCombatBonus(dwarfvsgiantbonus);

            DefenseBonus dwarfdefensebonus1 = new DefenseBonus(ATTACK_REGULAR, 4);
            dwarfdefensebonus1.AddCreatureSubtype(CREATURESUBTYPE_GIANT);
            dwarf.AddCombatBonus(dwarfdefensebonus1);

            // ELF RACE
            PlayerRace elf = new PlayerRace("coreelf", "Elf");
            elf.DefineRaceTraits(SIZE_MEDIUM, 30, false);
            elf.SetDescriptions("Although generally taller than humans, elves possess a graceful, fragile physique that is accentuated by their long, pointed ears. Their eyes are wide and almond-shaped, and filled with large, vibrantly colored pupils. While elven clothing often plays off the beauty of the natural world, those elves that live in cities tend to bedeck themselves in the latest fashion.",
                "Many elves feel a bond with nature and strive to live in harmony with the natural world. Most, however, find manipulating earth and stone to be distasteful, and prefer instead to indulge in the finer arts, with their inborn patience making them particularly suited to wizardry.",
                "Elves are prone to dismissing other races, writing them off as rash and impulsive, yet they are excellent judges of character. An elf might not want a dwarf neighbor, but would be the first to acknowledge that dwarf's skill at smithing. They regard gnomes as strange (and sometimes dangerous) curiosities, and halflings with a measure of pity, for these small folk seem to the elves to be adrift, without a traditional home. Elves are fascinated with humans, as evidenced by the number of half-elves in the world, even if they usually disown such offspring. They regard half-orcs with distrust and suspicion.",
                "Elves are emotional and capricious, yet value kindness and beauty. Most elves are chaotic good.",
                "Many elves embark on adventures out of a desire to explore the world, leaving their secluded forest realms to reclaim forgotten elven magic or search out lost kingdoms established millennia ago by their forefathers. For those raised among humans, the ephemeral and unfettered life of an adventurer holds natural appeal. Elves generally eschew melee because of their frailty, preferring instead to pursue classes such as wizards and rangers.",
                "TRAIT DESCRIPTIONS");
            elf.AddStatModifier(DEX, 2);
            elf.AddStatModifier(INT, 2);
            elf.AddStatModifier(CON, -2);
            elf.AddSensesModifier(SENSE_DIMVISION, 60);
            elf.AddSkillBonus(SKILL_PERCEPTION, 2);
            elf.AddSkillBonus(SKILL_SPELLCRAFT, 2);
            elf.AddKnownLanguage(LANG_COMMON);
            elf.AddKnownLanguage(LANG_ELF);
            elf.AddAvailableLanguage(LANG_CELESTIAL);
            elf.AddAvailableLanguage(LANG_DRAGON);
            elf.AddAvailableLanguage(LANG_GNOLL);
            elf.AddAvailableLanguage(LANG_GNOME);
            elf.AddAvailableLanguage(LANG_GOBLIN);
            elf.AddAvailableLanguage(LANG_ORC);
            elf.AddAvailableLanguage(LANG_SYLVAN);
            elf.AddUsableEquipment("longbow");
            elf.AddUsableEquipment("complongbow");
            elf.AddUsableEquipment("longsword");
            elf.AddUsableEquipment("rapier");
            elf.AddUsableEquipment("shortbow");
            elf.AddUsableEquipment("compshortbow");

            PlayerRace gnome = new PlayerRace("coregnome", "Gnome");

            
            // Add Races
            Races.Add(dwarf);
            Races.Add(elf);
            Races.Add(gnome);
        }

        public static void PopulateItems()
        {

        }

        public static void PopulateEquipment()
        {

        }

        public static void PopulateSkills()
        {

        }

        public static void PopulateAbilities()
        {

        }

        public static void PopulateSpells()
        {

        }
    }
}
