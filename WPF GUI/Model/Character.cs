using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WPF_GUI.Model
{
    class Character
    {
        public string Name { get; set; }
        public float Health { get; set; }
        public int Experience { get; set; }
        public int Level { get; set; }
        public byte Class { get; set; }
        public byte Specialization { get; set; }

        public Pet CurrentPet { get; set; }

        public int Race { get; set; }
        public byte Gender { get; set; }
        public int Face { get; set; }
        public int Hair { get; set; }
        public int HairColor { get; set; }

        public int Coins { get; set; }
        public int PlatinumCoins { get; set; }
    }
}
