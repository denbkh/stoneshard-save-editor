using System.ComponentModel;

namespace StoneshardSaveEditor
{
    public class CharacterData
    {
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Agility { get; set; }
        public int Perception { get; set; }
        public int Vitality { get; set; }
        public int Willpower { get; set; }
        public int AbilityPoints { get; set; }
        public int StatsPoints { get; set; }
        public int Level { get; set; }
        public int XP { get; set; }
        public int XPGain { get; set; }
        public int HP {  get; set; }
        public int MP { get; set; }
        public decimal Sanity {  get; set; }
        public decimal Morale { get; set; }
        public decimal Intoxication {  get; set; }
        public decimal Thirst { get; set; }
        public decimal Hunger { get; set; }
        public decimal Immunity {  get; set; }
        public int Fatigue {  get; set; }
        public int Pain {  get; set; }
        public string GameTime { get; set; }
        public BindingList<string> Abilities { get; set; }
    }
}
