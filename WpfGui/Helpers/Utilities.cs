using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WpfGui.Helpers
{
    public static class Utilities
    {
        public static T ParseEnum<T>(string value)
        {
            return (T)Enum.Parse(typeof(T), value, true);
        }
    }
}
