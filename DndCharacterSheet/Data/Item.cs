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
        public int modifier { get; set; }
        [Required] 
        public string modifies { get; set; }
        [Required]
        public string name { get; set; } 
        public string description { get; set; }

        public Item()
        {
            name = "default";
            modifier = 0;
            modifies = "";
        }

    }
}
