using System;
using System.ComponentModel;
using Newtonsoft.Json.Linq;

namespace StoneshardSaveEditor
{
    public class SaveEditor
    {
        private readonly string _saveFilePath;

        public SaveEditor(String saveFilePath)
        {
            _saveFilePath = saveFilePath;
        }

        public CharacterData ReadCharacter()
        {
            var jsonObject = Utils.ReadJson(_saveFilePath);
            var character = new CharacterData();
            
            var charDataMap = jsonObject["characterDataMap"];
            character.Name = charDataMap.Value<string>("nameKey");
            character.Strength = charDataMap.Value<int>("STR");
            character.Agility = charDataMap.Value<int>("AGL");
            character.Perception = charDataMap.Value<int>("PRC");
            character.Vitality = charDataMap.Value<int>("Vitality");
            character.Willpower = charDataMap.Value<int>("WIL");
            character.AbilityPoints = charDataMap.Value<int>("SP");
            character.StatsPoints = charDataMap.Value<int>("AP");
            character.Willpower = charDataMap.Value<int>("WIL");
            character.Level = charDataMap.Value<int>("LVL");
            character.XP = charDataMap.Value<int>("XP");

            var timeDataMap = jsonObject["timeDataMap"];
            var playTime = new TimeSpan();
            playTime.Add(TimeSpan.FromDays(timeDataMap.Value<int>("seconds")));
            playTime.Add(TimeSpan.FromDays(timeDataMap.Value<int>("minutes")));
            playTime.Add(TimeSpan.FromDays(timeDataMap.Value<int>("hours")));
            playTime.Add(TimeSpan.FromDays(timeDataMap.Value<int>("days")));
            playTime.Add(TimeSpan.FromDays(timeDataMap.Value<int>("months")));
            character.GameTime = playTime;

            character.Abilities = new BindingList<string>();
            // JArray skillsArray = (JArray)jsonObject["skillsDataMap"]["skillsAllDataList"];
            // for (int i = 0; i < skillsArray.Count; i += 4)
            // {
            //     
            // }
            
            return character;
        }
    }
}