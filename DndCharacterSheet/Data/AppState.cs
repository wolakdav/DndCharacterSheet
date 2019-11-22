using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DndCharacterSheet.Data
{
    public class AppState
    {
        public CharacterSheetModel character { get; private set; }
        public void SetCharacter(CharacterSheetModel newChar)
        {
            character = newChar;
        }


    }
}
