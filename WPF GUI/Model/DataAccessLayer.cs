using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SQLite;
using System.IO;
using zlib;
using System.Text;

namespace WPF_GUI.Model
{
    public interface IDataAccessLayer
    {
        List<Character> GetCharacters(String filepath);
    }

    public class DataAccessLayer : IDataAccessLayer
    {
        private SQLiteConnection connection;

        public List<Character> GetCharacters(String filepath = @"\Cube World\Save")
        {
            return new List<Character>();
        }
    }
}
