using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWEB2010_Project3
{
    class Scholarship : Resident
    {
        public Scholarship(string idNum, string fName, string lName, string dormNum, string resType, string level)
        {
            this.idNum = idNum;
            this.fName = fName;
            this.lName = lName;
            this.dormNum = dormNum;
            this.level = level;
            this.resType = resType;
            rentMoney = 100;
        }
        public Scholarship(string[] resLine)
        {
            idNum = resLine[0];
            fName = $"{resLine[1]}";
            lName = $"{resLine[2]}";
            dormNum = resLine[3];
            level = resLine[4];
            rentMoney = 100;
            resType = resLine[6];
        }
    }
}
