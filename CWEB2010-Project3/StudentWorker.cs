using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWEB2010_Project3
{
    class StudentWorker : Resident
    {
        public int hoursWorked { get; set; }

        public StudentWorker(string idNum, string fName, string lName, string dormNum, string resType, string level, int hoursWorked)
        {
            this.idNum = idNum;
            this.fName = fName;
            this.lName = lName;
            this.dormNum = dormNum;
            this.level = level;
            this.resType = resType;
            this.hoursWorked = hoursWorked;
            rentMoney = Convert.ToInt32(1245 - (hoursWorked / 2) * 14);
        }
        public StudentWorker(string[] resLine)
        {
            idNum = resLine[0];
            fName = $"{resLine[1]}";
            lName = $"{resLine[2]}";
            dormNum = resLine[3];
            level = resLine[4];
            rentMoney = Convert.ToInt32(resLine[5]);
            resType = resLine[6];
        }
    }
}
