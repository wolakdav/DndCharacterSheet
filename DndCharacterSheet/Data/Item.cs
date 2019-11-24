using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DndCharacterSheet.Data
{
    public class Item
    {
        [Required]
        public Guid Id { get; set; }
        [Required] 
        public int attackBonus { get; set; }
        [Required] 
        public int attackDie { get; set; }
        [Required]
        public int amtAttackDie { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public int damageDie { get; set; }
        [Required]
        public int amtDamageDie { get; set; }
        public int damageBonus { get; set; }
        public string description { get; set; }
        public bool isWeapon { get; set; }

        public Item()
        {
            name = "Weapon";
            attackBonus = 0;
            attackDie = 0;
            amtAttackDie = 1;
            damageDie = 0;
            amtDamageDie = 1;
            damageBonus = 0;

        }

    }
}
