using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CWEB2010_Project3
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            const string filePath = "residents.csv";
            Dictionary<int, Resident> resDict = new Dictionary<int, Resident>();

            readResidentFile(filePath, ref resDict);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(ref resDict));

            writeToResFile(filePath, ref resDict);
        }

        public static void readResidentFile(string filePath, ref Dictionary<int, Resident> resDict)
        {
            string[] resLine;

            FileStream testingFile = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(testingFile);

            while (!sr.EndOfStream)
            {
                resLine = sr.ReadLine().Split(',');
                switch (resLine[6])
                {
                    case "Scholarship Recipient":
                        resDict.Add(Convert.ToInt32(resLine[0]), new Scholarship(resLine));
                        break;
                    case "Student Worker":
                        resDict.Add(Convert.ToInt32(resLine[0]), new StudentWorker(resLine));
                        break;
                    case "Student Athlete":
                        resDict.Add(Convert.ToInt32(resLine[0]), new StudentAthlete(resLine));
                        break;
                }
            }

            sr.Close();
            testingFile.Close();
        }

        public static void writeToResFile(string filePath, ref Dictionary<int, Resident> resDict)
        {
            FileStream testingFile = new FileStream(filePath, FileMode.Open, FileAccess.Write);
            StreamWriter sw = new StreamWriter(testingFile);

            foreach (Resident res in resDict.Values)
            {
                sw.WriteLine($"{res.idNum},{res.fName},{res.lName},{res.dormNum},{res.level},{res.rentMoney},{res.resType}");
            }

            sw.Close();
            testingFile.Close();
        }
    }
}
