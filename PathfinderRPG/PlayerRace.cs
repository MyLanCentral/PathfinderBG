using System.Collections.Generic;

namespace PathfinderRPG
{
    public class PlayerRace
    {
        /// <summary>
        /// Referential type-name
        /// </summary>
        public string ShortName { get; protected set; }
        /// <summary>
        /// Display name for in-game menus and dialog
        /// </summary>
        public string LongName { get; protected set; }
        /// <summary>
        /// Descriptive Text used in Menus during Character Creation
        /// </summary>
        public Dictionary<string, string> Descriptions { get; protected set; }

        /// <summary>
        /// Size Reference, use GameCodex.SIZE_ constants to define
        /// </summary>
        public string Size { get; protected set; }
        /// <summary>
        /// Base Speed of Race in Feet
        /// </summary>
        public int Speed { get; protected set; }
        /// <summary>
        /// Defines if the Base Speed can be decreased by armor/encumbrance
        /// </summary>
        public bool IsSpeedLocked { get; protected set; }

        /// <summary>
        /// Stat Modifier Bonuses / Penalties Applied by Race
        /// </summary>
        public Dictionary<string, int> Stats { get; protected set; }
        /// <summary>
        /// Base Save Bonuses / Penalties Applied by Race
        /// </summary>
        public Dictionary<string, int> Saves { get; protected set; }
        /// <summary>
        /// Bonuses / Penalties applicable to any Skill, Applied by Race
        /// </summary>
        public Dictionary<string, int> SkillBonuses { get; protected set; }
        /// <summary>
        /// Senses added by Race, and to what extent (e.g. Darkvision, Dimvision, etc)
        /// </summary>
        public Dictionary<string, int> Senses { get; protected set; }
        /// <summary>
        /// Definied Racial Abilities; spell-like abilities, special-rule type bonuses, etc.
        /// </summary>
        public List<string> Abilities { get; protected set; }
        /// <summary>
        /// Equipment that can be used by the Race without penalty of non-proficiency
        /// </summary>
        public List<string> UsableEquipment { get; protected set; }
        /// <summary>
        /// Languages known by Race regardless of Intelligence
        /// </summary>
        public List<string> KnownLanguages { get; protected set; }
        /// <summary>
        /// All possible know-able languages by race
        /// </summary>
        public List<string> AvailableLanguages { get; protected set; }

        public List<CombatBonus> CombatBonuses { get; protected set; }

        public PlayerRace(string shortName, string longName)
        {
            ShortName = shortName;
            LongName = longName;

            Initialize();
        }

        public PlayerRace(string shortName, string longName, Dictionary<string,string> descriptions, string size, int speed, bool isSpeedLocked,
            Dictionary<string,int> stats, Dictionary<string, int> saves, Dictionary<string,int> skillBonuses, Dictionary<string,int> senses,
            List<string> abilities, List<string> usableEquipment, List<string> knownLanguages, List<string> availableLanguages)
        {
            ShortName = shortName;
            LongName = longName;
            Descriptions = new Dictionary<string, string>(descriptions);

            Size = size;
            Speed = speed;
            IsSpeedLocked = isSpeedLocked;

            Stats = new Dictionary<string, int>(stats);
            Saves = new Dictionary<string, int>(saves);
            SkillBonuses = new Dictionary<string, int>(skillBonuses);
            Senses = new Dictionary<string, int>(senses);
            Abilities = new List<string>(abilities);
            UsableEquipment = new List<string>(usableEquipment);
            KnownLanguages = new List<string>(knownLanguages);
            AvailableLanguages = new List<string>(availableLanguages);
        }

        private void Initialize()
        {
            Descriptions = new Dictionary<string, string>();
            Descriptions.Add("Physical", "");
            Descriptions.Add("Society", "");
            Descriptions.Add("Relations", "");
            Descriptions.Add("Alignment", "");
            Descriptions.Add("Adventurers", "");
            Descriptions.Add("Traits", "");

            Size = "Medium";
            Speed = 30;
            IsSpeedLocked = false;

            Stats = new Dictionary<string, int>();
            Saves = new Dictionary<string, int>();
            Senses = new Dictionary<string, int>();
            SkillBonuses = new Dictionary<string, int>();
            Abilities = new List<string>();
            UsableEquipment = new List<string>();
            KnownLanguages = new List<string>();
            AvailableLanguages = new List<string>();
        }

        public void AddAbility(string abilityShortName)
        {
            if(Abilities.Count == 0)
            {
                Abilities.Add(abilityShortName);
            }
            else
            {
                foreach(string ability in Abilities)
                {
                    if(ability == abilityShortName)
                    {
                        return;
                    }
                }

                Abilities.Add(abilityShortName);
                return;
            }
        }
        public void RemoveAbility(string skillShortName)
        {
            Abilities.Remove(skillShortName);
        }
        public void AddStatModifier(string statShortName, int modifier)
        {
            if(Stats.Count == 0)
            {
                Stats.Add(statShortName, modifier);
            }
            else
            {
                foreach(var stat in Stats)
                {
                    if(stat.Key == statShortName)
                    {
                        if(modifier == 0)
                        {
                            Stats.Remove(statShortName);
                            return;
                        }
                        else
                        {
                            Stats[statShortName] = modifier;
                            return;
                        }
                    }
                }

                Stats.Add(statShortName, modifier);

            }
        }
        public void AddSaveModifier(string saveShortName, int modifier)
        {
            if (Saves.Count == 0)
            {
                Saves.Add(saveShortName, modifier);
            }
            else
            {
                foreach (var save in Saves)
                {
                    if (save.Key == saveShortName)
                    {
                        if (modifier == 0)
                        {
                            Saves.Remove(saveShortName);
                            return;
                        }
                        else
                        {
                            Saves[saveShortName] = modifier;
                            return;
                        }
                    }
                }

                Saves.Add(saveShortName, modifier);

            }
        }
        public void AddSensesModifier(string senseShortName, int modifier)
        {
            if (Senses.Count == 0)
            {
                Senses.Add(senseShortName, modifier);
            }
            else
            {
                foreach (var sense in Senses)
                {
                    if (sense.Key == senseShortName)
                    {
                        if (modifier == 0)
                        {
                            Senses.Remove(senseShortName);
                            return;
                        }
                        else
                        {
                            Senses[senseShortName] = modifier;
                            return;
                        }
                    }
                }

                Senses.Add(senseShortName, modifier);

            }
        }
        public void AddSkillBonus(string skillShortName, int modifier)
        {
            if (SkillBonuses.Count == 0)
            {
                SkillBonuses.Add(skillShortName, modifier);
            }
            else
            {
                foreach (var skill in SkillBonuses)
                {
                    if (skill.Key == skillShortName)
                    {
                        if (modifier == 0)
                        {
                            SkillBonuses.Remove(skillShortName);
                            return;
                        }
                        else
                        {
                            SkillBonuses[skillShortName] = modifier;
                            return;
                        }
                    }
                }

                SkillBonuses.Add(skillShortName, modifier);

            }
        }
        public void AddUsableEquipment(string equipmentShortName)
        {
            if(UsableEquipment.Count == 0)
            {
                UsableEquipment.Add(equipmentShortName);
                return;
            }
            else
            {
                foreach(string equipment in UsableEquipment)
                {
                    if(equipment == equipmentShortName)
                    {
                        return;
                    }
                }

                UsableEquipment.Add(equipmentShortName);
                return;
            }
        }
        public void RemoveUsableEquipment(string equipmentShortName)
        {
            UsableEquipment.Remove(equipmentShortName);
        }
        public void AddKnownLanguage(string languageShortName)
        {
            if(KnownLanguages.Count == 0)
            {
                KnownLanguages.Add(languageShortName);
            }
            else
            {
                foreach(string language in KnownLanguages)
                {
                    if(language == languageShortName)
                    {
                        return;
                    }
                }

                KnownLanguages.Add(languageShortName);
                return;
            }
        }
        public void RemoveKnownLanguage(string languageShortName)
        {
            KnownLanguages.Remove(languageShortName);
        }
        public void AddAvailableLanguage(string languageShortName)
        {
            if (AvailableLanguages.Count == 0)
            {
                AvailableLanguages.Add(languageShortName);
            }
            else
            {
                foreach (string language in AvailableLanguages)
                {
                    if (language == languageShortName)
                    {
                        return;
                    }
                }

                AvailableLanguages.Add(languageShortName);
                return;
            }
        }
        public void RemoveAvailableLanguage(string languageShortName)
        {
            AvailableLanguages.Remove(languageShortName);
        }
        public void AddCombatBonus(CombatBonus bonus)
        {
            if (CombatBonuses.Count == 0)
            {
                CombatBonuses.Add(bonus);
            }
            else
            {
                foreach (CombatBonus combatBonus in CombatBonuses)
                {
                    if (combatBonus == bonus)
                    {
                        return;
                    }
                }

                CombatBonuses.Add(bonus);
                return;
            }
        }
        
        public void SetDescription(string descriptionType, string description)
        {
            foreach(var desc in Descriptions)
            {
                if(desc.Key == descriptionType)
                {
                    Descriptions[descriptionType] = description;
                    return;
                }
            }

            return;
        }
        public void SetDescriptions(string physical, string society, string relations, string alignment, string adventurers, string traits)
        {
            Descriptions["Physical"] = physical;
            Descriptions["Society"] = society;
            Descriptions["Relations"] = relations;
            Descriptions["Alignment"] = alignment;
            Descriptions["Adventurers"] = adventurers;
            Descriptions["Traits"] = traits;
        }

        public void DefineRaceTraits(string size, int speed, bool isSpeedLocked)
        {
            Size = size;
            Speed = speed;
            IsSpeedLocked = isSpeedLocked;
        }
    }
}
