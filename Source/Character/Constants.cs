namespace CharacterEditor.Character
{
	public static class Constants
	{
		public enum ItemType : byte
		{
			None,
			Consumables,
			Recipes,
			Weapons,
			ChestArmor,
			Gloves,
			Boots,
			ShoulderArmor,
			Amulets,
			Rings,
			Blocks,
			Items,
			Coins,
			PlatinumCoins,
			Leftovers,
			Beak,
			Painting,
			Vase,
			Candle,
			Pets,
			PetFood,
			QuestItems,
			Unused,
			Transportation,
			Lamps,
			ManaCubes
		};

		public static readonly string[] ItemTypeNames = new[]
		{
			"None",				// None
			"Consumables",
			"Recipes",
			"Weapons",
			"Chest Armor",
			"Gloves",
			"Boots",
			"Shoulder Armor",
			"Amulets",
			"Rings",
			"Blocks",
			"Items",
			"Coins",
			"Platinum Coins",
			"Leftovers",
			"Beak",
			"Painting",
			"Vase",
			"Candle",
			"Pets",
			"Pet Food",
			"Quest Items",
			null,
			"Transportation",
			"Lamps",
			"Mana Cubes"
		};

		public static readonly string[][] ItemModifiers = new []
		{
			new []					// Rarity 0
			{
				"Unwieldy {0}",
				"Used {0}",
				"Dusty {0}",
				"Scratched {0}",
				"Worn {0}",
				"Common {0}",
				"Shabby {0}",
				"Plain {0}",
				"Battered {0}",
				"Artless {0}"
			},

			new []					// Rarity 1
			{
				"Handmade {0}",
				"Fair {0}",
				"Neat {0}",
				"Clean {0}",
				"Undamaged {0}",
				"Flawless {0}",
				"Adjusted {0}",
				"Balanced {0}",
				"Battle-tested {0}",
				"Good {0}"
			},

			new []					// Rarity 2
 			{
				"Superb {0}",
				"Unique {0}",
				"Handsome {0}",
				"Grand {0}",
				"Magic {0}",
				"Decorated {0}",
				"Exceptional {0}",
				"Polished {0}",
				"Extraordinary {0}",
				"Exquisite {0}"
			},

			new[]					// Rarity 3
			{
				"{1}'s superb {0}",
				"unique {0} of {1}",
				"{1}'s handsome {0}",
				"grand {0} of {1}",
				"magic {0} of {1}",
				"decorated {0} of {1}",
				"{1}'s exceptional {0}",
				"polished {0} of {1}",
				"extraordinary {0} of {1}",
				"exquisite {0} of {1}"
			},

			new []					// Rarity 4
			{
				"{1}'s pompous {0}",
				"glorious {0} of {1}",
				"{1}'s splendid {0}",
				"famous {0} of {1}",
				"legendary  {0} of {1}",
				"fabulous {0} of {1}",
				"{1}'s brilliant {0}",
				"shining {0} of {1}",
				"Magnificent {0} von {1}",
				"Sublime {0} of {1}"
			}
		};

		public static readonly string[] ItemMaterialNames = new[]
		{
			"None",			// Might be a problem?
			"Iron",
			"Wood",
			null,
			null,
			"Obsidian",
			null,
			"Bone",
			null,
			null,
			"Copper",
			"Gold",
			"Silver",
			"Emerald",
			"Sapphire",
			"Ruby",
			"Diamond",
			"Sandstone",
			"Saurian",
			"Parrot",
			"Mammoth",
			"Plant",
			"Ice",
			"Licht",
			"Glass",
			"Silk",
			"Linen",
			"Cotton",
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			"Fire",
			"Unholy",
			"Ice",
			"Wind"
		};

		// [type][subtype]
		public static readonly string[][] ItemSubtypes = new[]
		{
			new []						// None
			{
				""
			}, 
			new []						// Consumable
			{
				"Cookie",
				"Life Potion",
				"Cactus Potion",
				"Mana Potion",
				"Ginseng Soup",
				"Snowberry Mash",
				"Mushroom Spit",
				"Bomb",
				"Pineapple Slice",
				"Pumpkin Muffin"
			},
			new []						// Recipes
			{
				"Recipe"
			}, 
			new []						// Weapons
			{
				"Sword",
				"Axe",
				"Mace",
				"Dagger",
				"Fist",
				"Longsword",
				"Bow",
				"Crossbow",
				"Boomarang",
				"Arrow",
				"Staff",
				"Wand",
				"Bracelet",
				"Shield",
				"Arrows",
				"Greatsword",
				"Greataxe",
				"Greatmace",
				"Rake",
				"Pickaxe",
				"Torch"
			},
			new []						// Chest Armor
			{
				"Chest Armor"
			},
			new []						// Gloves
			{	
				"Gloves"
			},
			new []						// Boots
			{
				"Boots"
			},
			new []						// Shoulder Armor
			{
				"Shoulder Armor"
			},
			new []						// Amulets
			{
				"Amulet"
			},
			new []						// Rings
			{
				"Ring"
			},
			new []						// Blocks
			{
				"Block"
			},
			new []						// Items
			{
				"Nugget",
				"Log",
				"Feather",
				"Horn",
				"Claw",
				"Fiber",
				"Cobweb",
				"Hair",
				"Crystal",
				"Yarn",
				"Cube",
				"Capsule",
				"Flask",
				"Orb",
				"Spirit",
				"Mushroom",
				"Pumpkin",
				"Pineapple",
				"Radish Slice",
				"Shimmer Mushroom",
				"Ginseng Root",
				"Onion Slice",
				"Heartflower",
				"Prickly Pear",
				"Iceflower",
				"Soulflower",
				"Water Flask",
				"Snowberry"
			},
			new []						// Coins
			{
				"Coin"
			},
			new []						// Platinum Coins
			{
				"Platinum Coin"
			},
			new []						// Leftovers
			{
				"Leftovers"
			},
			new []						// Beak
			{
				"Beak"
			},
			new []						// Painting
			{
				"Painting"
			},
			new []						// Vase
			{
				"Vase"
			},
			new []						// Candle
			{
				"Candle",
				"Haunted Candle"
			},
			new []						// Pets
			{
				"", "", "", "", "", "", "", "", 
				"", "", "", "", "", "", "", "", 
				"", "", "",
				"Collie",
				"Shepherd Dog",
				"",
				"Alpaca",
				"Alpaca (Brown)",
				"",
				"Turtle",
				"Terrier",
				"Terrier (Scottish)",
				"Wolf",
				"",
				"Cat",
				"Cat (Brown)",
				"Cat (White)",
				"Pig",
				"Sheep",
				"Bunny",
				"Porcupine",
				"Slime (Green)",
				"Slime (Pink)",
				"Slime (Yellow)",
				"Slime (Blue)",
				"", "", "", "", "", "", "", "",
				"",
				"Monkey",
				"", "",
				"Hornet",
				"",
				"Crow",
				"Chicken",
				"Seagull",
				"Parrot",
				"Bat",
				"Fly",
				"Midge",
				"Mosquito",
				"Runner (Plain)",
				"Runner (Leaf)",
				"Runner (Snow)",
				"Runner (Desert)",
				"Peacock",
				"Frog",
				"", "", "", "",
				"Devourer",
				"Duckbill",
				"Crocodile",
				"", "", "", "", "", "", "", "", "", 
				"Imp",
				"Spitter",
				"Mole",
				"Biter",
				"Koala",
				"Squirrel",
				"Raccoon",
				"Owl",
				"Penguin",
				"", "", "", "",
				"Horse",
				"Camel",
				"", "",
				"Beetle (Dark)",
				"Beetle (Fire)",
				"Beetle (Snout)",
				"Beetle (Lemon)",
				"Crab",
				"", "", "", "", "", "", "", "", 
				"", "", "", "", "", "", "", "", 
				"", "", "", "", "", "", "", "", 
				"", "", "", "", "", "", "", "", 
				"", "", "", "", "", "", "", "",
				"", "", "", "",
				"Bumblebee"
			}, 
			new []						// Pet Food
			{
				"", "", "", "", "", "", "", "",
				"", "", "", "", "", "", "", "",
				"", "", "",
				"Bubble Gum",
				"", "", "",
				"Chocolate Cupcake",
				"",
				"Cinnamon Roll",
				"Waffle",
				"Croissant",
				"",
				"",
				"Candy",
				"",
				"",
				"Pumpkin Mash",
				"Cotton Candy",
				"Carrot",
				"Blackberry Marmalade",
				"Green Jelly",
				"Pink Jelly",
				"Yellow Jelly",
				"Blue Jelly",
				"", "", "", "", "", "", "", "", "", 
				"Banana Split",
				"", "", 
				"Popcorn",
				"", 
				"Licorice Candy",
				"Cereal Bar",
				"Salted Caramel",
				"Ginger Tartlet",
				"Mango Juice",
				"Fruit Basket",
				"Melon Icecream",
				"Bloodorange Juice",
				"Milk chocolate bar",
				"Mint chocolate bar",
				"White chocolate bar",
				"Caramel chocolate bar",
				"Chocolate Cookie",
				"", "", "", "", "", "",
				"Sugar Candy",
				"Apple Ring",
				"", "", "", "", "", "", "", "", "", "",
				"Water Ice",
				"Chocolate Doughnut",
				"Pancakes",
				"",
				"Strawberry Cake",
				"Chocolate Cake",
				"Lollipop",
				"Softice",
				"", "", "", "", 
				"Candied Apple",
				"Date Cookie",
				"", "",
				"Bread",
				"Curry",
				"Lolly",
				"Lemon Tart",
				"Starberry Cocktail"
			},
			new []						// Quest Items
			{
				"Amulet (Gold)",
				"Amulet (Sapphire)",
				"Jewel Case",
				"Key",
				"Medicine",
				"Antivenom",
				"Band Aid",
				"Crutch",
				"Bandage",
				"Salve"
			},
			new []						// Unused
			{
				""
			}, 
			new []						// Transportation
			{
				"Hang Glider",
				"Boat"
			},
			new []						// Lamps
			{
				"Lamp"
			},
			new []						// Mana Cubes
			{
				"Mana Cube"
			}
		};
	}
}
