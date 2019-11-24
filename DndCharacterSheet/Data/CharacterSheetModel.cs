using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace DndCharacterSheet.Data
{
    public class CharacterSheetModel
    {
        [Required]
        public string Name { get; set; } = "Default Name";
        public int level { get; set; }
        public int baseStrength { get; set; }
        public int currentStrength { get; set; }
        public int strengthMod { get; set; } = 0;
        public int baseDexterity { get; set; }
        public int currentDexterity { get; set; }
        public int dexterityMod { get; set; } = 0;
        public int baseConstitution { get; set; }
        public int currentConstitution { get; set; }
        public int constitutionMod { get; set; } = 0;
        public int baseIntelligence { get; set; }
        public int currentIntelligence { get; set; }
        public int intelligenceMod { get; set; } = 0;
        public int baseWisdom { get; set; }
        public int currentWisdom { get; set; }
        public int wisdomMod { get; set; } = 0;
        public int baseCharisma { get; set; }
        public int currentCharisma { get; set; }
        public int charismaMod { get; set; } = 0;
        public int inspiration { get; set; } = 0;
        public int profBonus { get; set; } = 2;
        public int maxHitpoints { get; set; }
        public int acutalHitPoints { get; set; }
        public int hitDie { get; set; }
        public int speed { get; set; }
        public int tempHitPoints { get; set; } = 0;
        public int NumbSuccDeathSave { get; set; } = 0;
        public int NumbFailDeathSave { get; set; } = 0;
        public int baseArmorClass { get; set; } = 10;
        public int currentArmorClass {get; set;} = 0;
        public int armorClassModifier { get; set; } = 0;
        public List<Item> inventory { get; set; } = new List<Item>();

        public CharacterSheetModel(int level,int healthDie,int walkingSpeed = 30)
        {
            this.speed = walkingSpeed;
            this.level = level;
            this.hitDie = healthDie;
            Random random = new Random();
            List<int> rolls = new List<int>();
            int amountUnder10 = 0;
            for (int i = 0; i < 7; i = i + 1)
            {
                var potRolls = new List<int>();
                potRolls.Add(random.Next(0, 6));
                potRolls.Add(random.Next(0, 6));
                potRolls.Add(random.Next(0, 6));
                potRolls.Add(random.Next(0, 6));
                potRolls.OrderByDescending(x => x).Take(rolls.Count - 1).ToList();

                var roll = potRolls.Sum();
                if (roll < 10 && amountUnder10 >= random.Next(0,3))
                {
                    while(roll <= 10)
                    {
                        potRolls = new List<int>();
                        potRolls.Add(random.Next(0, 6));
                        potRolls.Add(random.Next(0, 6));
                        potRolls.Add(random.Next(0, 6));
                        potRolls.Add(random.Next(0, 6));
                        potRolls.OrderByDescending(x => x).Take(rolls.Count - 1).ToList();

                        roll = potRolls.Sum();
                    }
                }
                rolls.Add(roll);
            }
            List<int> statsToPick = new List<int> { 0, 1, 2, 3, 4 ,5};
            rolls.OrderByDescending(x => x).Take(rolls.Count - 2).ToList();
            for (int i = 0; i < 6; i = i + 1)
            {
           
                var statToFill = statsToPick[random.Next(0, statsToPick.Count)];
                switch (statToFill)
                {
                    case (0):
                        this.baseCharisma = rolls.First();
                        this.currentWisdom = this.baseCharisma;
                        statsToPick.Remove(0);
                        break;
                    case (1):
                        this.baseWisdom = rolls.First();
                        this.currentWisdom = this.baseWisdom;
                        statsToPick.Remove(1);
                        break;
                    case (2):
                        this.baseIntelligence = rolls.First();
                        this.currentIntelligence = this.baseIntelligence;
                        statsToPick.Remove(2);
                        break;
                    case (3):
                        this.baseConstitution = rolls.First();
                        this.currentConstitution = this.baseConstitution;
                        statsToPick.Remove(3);
                        break;
                    case (4):
                        this.baseDexterity = rolls.First();
                        this.currentDexterity = this.baseDexterity;
                        statsToPick.Remove(4);
                        break;
                    case (5):
                        this.baseStrength = rolls.First();
                        this.currentStrength = this.baseStrength;
                        statsToPick.Remove(5);
                        break;
                }
                rolls.RemoveAt(0);
            }

            this.baseArmorClass = 10 + ((this.currentDexterity % 10) / 2);
            this.currentArmorClass = this.baseArmorClass;

            var hitPoints = 0;
            for(int i = 0;i<level;i++)
            {
                hitPoints += this.baseConstitution + (random.Next(1, this.hitDie));
            }
            this.maxHitpoints = (baseConstitution + hitDie)+ hitPoints;
            this.acutalHitPoints = this.maxHitpoints;

            Item defaultWeapon = new Item();
            defaultWeapon.name = "Fists";
            defaultWeapon.description = "Angry? Try punching it, that might help";
            defaultWeapon.attackDie = 0;
            defaultWeapon.amtAttackDie = 0;
            defaultWeapon.attackBonus = 0;
            defaultWeapon.damageBonus = 1 + ((this.currentStrength - 10) / 2);
            defaultWeapon.damageDie = 0;
            defaultWeapon.amtDamageDie = 0;
            defaultWeapon.isWeapon = true;
            this.inventory.Add(defaultWeapon);
        }

        private void changeArmorClass(int changeAcBy)
        {
            if(armorClassModifier + changeAcBy <= 0)
            {
                this.armorClassModifier = 0;
                this.currentArmorClass = this.baseArmorClass;
            }
            else
            {
                this.armorClassModifier += changeAcBy;
                this.currentArmorClass = this.armorClassModifier + this.baseArmorClass;
            }
        }
    }
}
