using System.Collections.Generic;

namespace CharacterEditor.Character
{
	// CREDIT Ntl3fty
	public class NameGenerator
	{
		private static readonly IDictionary<int, string[,]> PartialNames = new Dictionary<int, string[,]>
        {
            {
                -1,
				new[,]
                {
                    { "Kro", "Aru", "As", "Ge", "Kur", "Lugo", "Iko", "Liku", "Tero", "Var", "An", "The", "Ga", "Lan", "Dura", "Dama", "Se", "Thal", "Nar", "San" },
                    { "no", "mi", "la", "sel", "ron", "ion", "kor", "lon", "rok", "tar", "den", "gar", "dar", "dara", "lan", "ka", "gor", "rior", "ria", "mor" }
                }
            },

            {
                0,
				new[,]
                {
                    { "El", "Li", "Dri", "Elan", "Le", "Ly", "A", "Tho", "Da", "Les" },
                    { "ric", "kun", "zic", "dor", "las", "sander", "reon", "reas", "lundra", "andor" }
                }
            },

            {
                1,
				new[,]
                {
                    { "Ar", "A", "Si", "Mer", "Lu", "Ari", "Su", "Sira", "Hia", "Li" },
                    { "weya", "luna", "laya", "leya", "ma", "lia", "matra", "vy", "zyna", "ly" }
                }
            },

            {
                2,
				new[,]
                {
                    { "De", "Ro", "As", "Ge", "An", "Pat", "Wolf", "Ale", "Mi", "Ben" },
                    { "rek", "man", "gram", "rald", "rick", "ram", "sander", "kal", "ton", "ny" }
                }
            },

            {
                3, new[,]
                    {
                        { "Sa", "Jen", "Kla", "Mi", "La", "Auri", "Mela", "Alu", "Ve", "Est" },
                        { "rah", "ny", "ria", "elle", "na", "ga", "ma", "riana", "rona", "una" }
                    }
            },

            {
                4,
				new[,]
                {
                    { "Gra", "Xe", "Ur", "Bel", "Chu", "Ki", "Go", "Zim", "Kubo", "Raz" },
                    { "zic", "nax", "tik", "tuk", "ruk", "bo", "rix", "mi", "tok", "nor" }
                }
            },

            {
                5,
				new[,]
                {
                    { "Kur", "Xe", "Ki", "Am", "Zifa", "Zu", "Ma", "Chi", "Zi", "Mia" },
                    { "ra", "lia", "bi", "ba", "ly", "ki", "bara", "mi", "zy", "xa" }
                }
            },

            {
                7,
				new[,]
                {
                    { "Cho", "Zer", "Kaz", "Kraz", "Zel", "Drak", "Lo", "Raz", "Spi", "Zen" },
                    { "rux", "rek", "zic", "tac", "mec", "kor", "rax", "zor", "ro", "go" }
                }
            },

            {
                8,
				new[,]
                {
                    { "Zi", "Zer", "Az", "Ki", "Iza", "Drak", "Li", "May", "Spi", "Zan" },
                    { "rya", "ri", "zia", "ki", "mah", "ira", "maya", "ana", "ra", "ya" }
                }
            },

            {
                9,
				new[,]
                {
                    { "Tor", "Gem", "Bar", "Me", "As", "Tem", "Arak", "Ur", "Grim", "Xor" },
                    { "lox", "bart", "kor", "thos", "kun", "bur", "thor", "lok", "li", "bor" }
                }
            },

            {
                10,
				new[,]
                {
                    { "Mum", "Grun", "Brun", "Hei", "Mo", "Hil", "Ur", "Lum", "Grim", "Xor" },
                    { "pie", "hild", "di", "muna", "ki", "trud", "sa", "axa", "ira", "ika" }
                }
            },

            {
                11,
				new[,]
                {
                    { "Uz", "Ur", "Chu", "Ku", "Mor", "Ura", "Ak", "Ur", "Or", "Gor" },
                    { "ku", "ruk", "muk", "thak", "dok", "tor", "rorok", "chak", "kaz", "rack" }
                }
            },

            {
                12,
				new[,]
                {
                    { "Uz", "Ur", "Chu", "Ku", "Mor", "Ura", "Ak", "Ur", "Or", "Gor" },
                    { "ka", "rua", "mua", "thara", "daka", "tah", "rorah", "chaka", "kaya", "rana" }
                }
            },

            {
                13,
				new[,]
                {
                    { "Qua", "Rib", "Quib", "Zib", "Il", "Wok", "Wib", "Moko", "Sli", "Bul" },
                    { "rik", "bit", "ble", "bik", "wak", "wok", "wib", "luk", "mey", "bak" }
                }
            },

            {
                14,
				new[,]
                {
                    { "Qua", "Rib", "Quib", "Zib", "Il", "Wok", "Wib", "Moko", "Sli", "Bul" },
                    { "ria", "bia", "bla", "bia", "waka", "woka", "wibba", "lua", "maya", "ba" }
                }
            },

            {
                15,
				new[,]
                {
                    { "Chu", "Dro", "Al", "Dem", "Mor", "Mur", "Cro", "Zul", "Dra", "The" },
                    { "lu", "kor", "card", "morius", "enius", "tus", "demar", "lus", "ruul", "zad" }
                }
            },

            {
                16,
				new[,]
                {
                    { "Xu", "Dra", "Al", "Dem", "Mor", "Myr", "Cra", "Zul", "Dri", "Thu" },
                    { "la", "kira", "cara", "moria", "ena", "tana", "diria", "laza", "rah", "zazah" }
                }
            }
        };

		static NameGenerator()
		{
			PartialNames[18] = PartialNames[2];
			PartialNames[43] = PartialNames[2];
			PartialNames[83] = PartialNames[2];

			PartialNames[45] = PartialNames[3];
			PartialNames[84] = PartialNames[3];
		}

		public static string Generate(int id, int type = -1)
		{
			string[,] partials;
			if (!PartialNames.TryGetValue(type, out partials))
				partials = PartialNames[-1];

			int index1 = (13 * id + id / 7) % partials.GetLength(1);
			int index2 = (id / 10 + 7 * id) % partials.GetLength(1);

			return partials[0, index1] + partials[1, index2];
		}
	}
}
