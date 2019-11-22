using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DndCharacterSheet.Data
{
    public class AppState
    {
        public CharacterSheetModel character { get; private set; }
        public event Action OnChange;
        public void SetCharacter(CharacterSheetModel newChar)
        {
            character = newChar;
            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnChange?.Invoke();

    }
}
