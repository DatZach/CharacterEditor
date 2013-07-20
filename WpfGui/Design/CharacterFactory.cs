using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CharacterEditor.Character;

namespace WpfGui.Design
{
    class CharacterFactory
    {
        public Character CreateMockCharacter()
        {
            var character = new Character(1);


            return character;
        }
    }
}
