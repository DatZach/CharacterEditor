using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;

namespace WPF_GUI.Model
{
    class IOHelpers
    {
        /// <summary>
        /// Returns the parent folder of character.db
        /// </summary>
        /// <param name="directory_format">How Wollay chooses to place his save file i.e. \Cube World\Save. As its an alpha it might change from time to time</param>
        /// <returns></returns>
        public static String GetSaveDirectory(String directory_format)
        {
            String[] possible_locations = {
                                              Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), 
                                              Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), 
                                              Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86)
                                          };
            foreach (String filepath in possible_locations)
            {
                String full_filepath = filepath + directory_format;
                if(Directory.Exists(filepath + directory_format))
                {
                    return full_filepath;
                }
            }

            return String.Empty;
            
        }
    }
}
