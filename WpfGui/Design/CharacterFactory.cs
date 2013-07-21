using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;
using CharacterEditor.Character;

namespace WpfGui.Design
{
    class CharacterFactory
    {
        public static Character CreateMockCharacter()
        {
            var lastWorld = new World() {Name = "NEWWORLD", Seed = 35496844, X = 550213180007, Y = 550481891163, Z = 12260532};
            var character = new Character(1)
                {
                    //Skills
                    ClimbingSkillLevel = 5,
                    HangGlidingSkillLevel = 1,

                    PetMasterSkillLevel = 0,
                    PetRidingSkillLevel = 0,

                    SailingSkillLevel = 0,
                    SwimmingSkillLevel = 1,

                    TierOneSkillLevel = 5,
                    TierTwoSkillLevel = 5,
                    TierThreeSkillLevel = 15,

                    //Appearance
                    Name = "Charles",
                    Race = 0,
                    Face = 0,
                    Gender = 0,
                    Hair = 2,

                    //Stats
                    Class = Character.ClassType.Ranger,
                    Specialization = 1,
                    Health = 605,
                    Level = 17,
                    Coins = 213000,
                    PlatinumCoins = 52,
                    Experience = 493,
                    
                    //Worlds
                    LastWorld = lastWorld,                    
                    Worlds = new[]{lastWorld}.ToList(),
                    
                    //Items
                    CraftingRecipes = new[]{CreateMockItem()}.ToList()
                    //TODO Implement Inventories
                };
            
            return character;
        }

        //TODO
        public static Inventory CreateMockInventory()
        {
            return null;
        }

        public static Item CreateMockItem()
        {
            var attributes = new List<ItemAttribute>();
            for (var i = 0; i < 32; i++)
            {
                attributes.Add(CreateMockItemAttribute());
            }

            var item = new Item()
                {
                    Type = 1,
                    Subtype = 1,
                    Attributes = attributes,
                    Flags = 0,
                    Level = 1,
                    Material = 0,
                    Modifier = 0,
                    Rarity = 0
                };
            return item;
        }

        public static ItemAttribute CreateMockItemAttribute()
        {
            return new ItemAttribute()
                {
                    Level = 0,
                    Material = 0,
                    OffsetX = 0,
                    OffsetY = 0,
                    OffsetZ = 0
                };
        }
    }
}
