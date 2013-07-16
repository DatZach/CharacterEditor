using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WPF_GUI.Model
{
    public class DataItem
    {
        public DataItem(List<Character> characters)
        {
            Characters = characters;
        }

        public List<Character> Characters
        {
            get;
            private set;
        }
    }
}
