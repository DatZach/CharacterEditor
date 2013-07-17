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

		// TODO Technically has subtypes (Will probably crash on some items)
		public static readonly string[] ItemModifiers = new []
		{
			"None",
			"Polish",
			"Extraordinary",
			"Exquisite",
			"Superb",
			"Unique",
			"Handsome",
			"Grand",
			"Magic",
			"Decorated",
			"Exceptional"
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
