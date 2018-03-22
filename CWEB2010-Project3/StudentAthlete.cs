using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWEB2010_Project3
{
    class StudentAthlete : Resident
    {
        public StudentAthlete(string idNum, string name, string dormNum, string resType, string level)
        {
            this.idNum = idNum;
            this.name = name;
            this.dormNum = dormNum;
            this.level = level;
            this.resType = resType;
            rentMoney = 1200;
        }
        public StudentAthlete(string[] resLine)
        {
            idNum = resLine[0];
            name = $"{resLine[1]} {resLine[2]}";
            dormNum = resLine[3];
            level = resLine[4];
            rentMoney = Convert.ToInt32(resLine[5]);
            resType = resLine[6];
        }
    }
}
