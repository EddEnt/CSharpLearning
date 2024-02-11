using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvHelper.SeedData
{
    internal class SeedMethods
    {
        public static void GenerateEntries()
        {
            string filePath = "entries.csv";
            Random random = new Random();

            if (!File.Exists(filePath))
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    for (int i = 0; i < 1000; i++)
                    {
                        int randomNumber = random.Next(1, 121);
                        writer.WriteLine(randomNumber);
                    }
                }
            }
        }
    }
}
