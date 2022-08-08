using System.Collections.Generic;

namespace StoneshardSaveEditor
{
    public class CharacterData
    {
        public string Name { get; set; }
        public string Strength { get; set; }
        public string Agility { get; set; }
        public string Perception { get; set; }
        public string Vitality { get; set; }
        public string Willpower { get; set; }
        public int AbilityPoints { get; set; }
        public int StatsPoints { get; set; }
        public int Level { get; set; }
        public int XP { get; set; }
        public List<string> Abilities { get; set; }
    }
}