using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWEB2010_Project3
{
    public abstract class Resident
    {
        public string idNum { get; set; }
        public string fName { get; set; }
        public string lName { get; set; }
        public string dormNum { get; set; }
        public int rentMoney { get; set; }
        public string level { get; set; }
        public string resType { get; set; }

        public Resident() { }

        public Resident(string idNum, string fName, string lName, string dormNum, string resType, string level)
        {
            this.idNum = idNum;
            this.fName = fName;
            this.lName = lName;
            this.dormNum = dormNum;
            this.level = level;
            this.resType = resType;
        }

    }
}
