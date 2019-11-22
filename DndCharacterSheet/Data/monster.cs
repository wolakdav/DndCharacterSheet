using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace DndCharacterSheet.Data
{
    public class Monster
    {
            [JsonProperty("_id")]
            public string Id { get; set; }

            [JsonProperty("index")]
            public long Index { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("size")]
            public string Size { get; set; }

            [JsonProperty("type")]
            public string Type { get; set; }

            [JsonProperty("subtype")]
            public string Subtype { get; set; }

            [JsonProperty("alignment")]
            public string Alignment { get; set; }

            [JsonProperty("armor_class")]
            public long ArmorClass { get; set; }

            [JsonProperty("hit_points")]
            public long HitPoints { get; set; }

            [JsonProperty("hit_dice")]
            public string HitDice { get; set; }

            [JsonProperty("speed")]
            public string Speed { get; set; }

            [JsonProperty("strength")]
            public long Strength { get; set; }

            [JsonProperty("dexterity")]
            public long Dexterity { get; set; }

            [JsonProperty("constitution")]
            public long Constitution { get; set; }

            [JsonProperty("intelligence")]
            public long Intelligence { get; set; }

            [JsonProperty("wisdom")]
            public long Wisdom { get; set; }

            [JsonProperty("charisma")]
            public long Charisma { get; set; }

            [JsonProperty("dexterity_save")]
            public long DexteritySave { get; set; }

            [JsonProperty("constitution_save")]
            public long ConstitutionSave { get; set; }

            [JsonProperty("wisdom_save")]
            public long WisdomSave { get; set; }

            [JsonProperty("charisma_save")]
            public long CharismaSave { get; set; }

            [JsonProperty("deception")]
            public long Deception { get; set; }

            [JsonProperty("insight")]
            public long Insight { get; set; }

            [JsonProperty("perception")]
            public long Perception { get; set; }

            [JsonProperty("persuasion")]
            public long Persuasion { get; set; }

            [JsonProperty("stealth")]
            public long Stealth { get; set; }

            [JsonProperty("damage_vulnerabilities")]
            public string DamageVulnerabilities { get; set; }

            [JsonProperty("damage_resistances")]
            public string DamageResistances { get; set; }

            [JsonProperty("damage_immunities")]
            public string DamageImmunities { get; set; }

            [JsonProperty("condition_immunities")]
            public string ConditionImmunities { get; set; }

            [JsonProperty("senses")]
            public string Senses { get; set; }

            [JsonProperty("languages")]
            public string Languages { get; set; }

            [JsonProperty("challenge_rating")]
            public long ChallengeRating { get; set; }

            [JsonProperty("special_abilities")]
            public LegendaryAction[] SpecialAbilities { get; set; }

            [JsonProperty("actions")]
            public Action[] Actions { get; set; }

            [JsonProperty("legendary_actions")]
            public LegendaryAction[] LegendaryActions { get; set; }

            [JsonProperty("url")]
            public Uri Url { get; set; }

        public static Monster FromJson(string json)
        {
            //return JsonConvert.DeserializeObject<Monster>(json, Services.JsonConverter.Settings);
            return Services.JsonConverter.FromJson<Monster>(json);
        }
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Services.JsonConverter.Settings);
        }
    }

        public class Action
        {
            [JsonProperty("attack_bonus")]
            public long AttackBonus { get; set; }

            [JsonProperty("desc")]
            public string Desc { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("damage_bonus", NullValueHandling = NullValueHandling.Ignore)]
            public long? DamageBonus { get; set; }

            [JsonProperty("damage_dice", NullValueHandling = NullValueHandling.Ignore)]
            public string DamageDice { get; set; }
        }

        public class LegendaryAction
        {
            [JsonProperty("attack_bonus")]
            public long AttackBonus { get; set; }

            [JsonProperty("desc")]
            public string Desc { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }
        }

        internal static class Converter
        {

        }
    }


