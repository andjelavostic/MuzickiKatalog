using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuzickiKatalog.Models
{
    public class GlobalID
    {
        private static int idValue = 0;
        public GlobalID()
        {
            LoadId(".//..\\..\\..\\Infrastructure\\Data\\id.txt");
        }
        public int NextId()
        {
            LoadId(".//..\\..\\..\\Infrastructure\\Data\\id.txt");
            ++idValue;
            SaveId(".//..\\..\\..\\Infrastructure\\Data\\id.txt");
            return idValue;


        }
        public void PreviousId()
        {
            LoadId(".//..\\..\\..\\Infrastructure\\Data\\id.txt");
            --idValue;
            SaveId(".//..\\..\\..\\Infrastructure\\Data\\id.txt");

        }
        private static void SaveId(string filePath)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine(idValue);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error saving IdGlobalCounter: " + ex.Message);
            }
        }
        private static void LoadId(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        string line = reader.ReadLine();
                        if (int.TryParse(line, out int result))
                        {
                            idValue = result;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading IdGlobalCounter: " + ex.Message);
            }
        }
    }
}
