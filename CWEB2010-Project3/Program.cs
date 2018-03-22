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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            const string filePath = "residents.csv";

            readResidentFile(filePath);
            
        }

        public static void readResidentFile(string filePath)
        {
            string[] resLine;
            Dictionary<int, Resident> resDict = new Dictionary<int, Resident>();

            FileStream testingFile = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(testingFile);

            while (!sr.EndOfStream)
            {
                resLine = sr.ReadLine().Split(',');
                switch (resLine[6])
                {
                    case "Scholarship":
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
    }
}
