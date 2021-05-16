using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* * * * * * * * * * * * *
 * * Warren Peterson * * *
 * This is my Own Work * *
 * CST-117 4/24/2021 * * *
 * * * * * * * * * * * * */

namespace Milestone2
{
    public class CSVManager
    {
        // readCSV method opens the saved CSV file and reads the lines in it
        public List<string[]> readCsv(string fileLocation)
        {
            List<string[]> lines = new List<string[]>();
            StreamReader reader = new StreamReader(File.OpenRead(@"" + fileLocation));
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (!String.IsNullOrWhiteSpace(line))
                {
                    lines.Add(line.Split(','));
                }
            }
            reader.Close();
            return lines;
        }
        // saveCSV method saves any changes that have been made to the CSV file
        public void saveCSV(string fileLocation, List<string[]> lines)
        {
            StringBuilder csv = new StringBuilder();

            foreach (string[] line in lines)
            {
                csv.AppendLine(String.Join(",", line));
            }
            File.WriteAllText(fileLocation, csv.ToString());
        }
    }
}