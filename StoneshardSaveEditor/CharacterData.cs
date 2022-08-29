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
    public string GameTime { get; set; }
    public BindingList<string> Abilities { get; set; }
  }
}
