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
        public string name { get; set; }
        public string dormNum { get; set; }
        public int rentMoney { get; set; }
        public string level { get; set; }
        public string resType { get; set; }

        public Resident() { }

        public Resident(string idNum, string name, string dormNum, string resType, string level)
        {
            this.idNum = idNum;
            this.name = name;
            this.dormNum = dormNum;
            this.level = level;
            this.resType = resType;
        }

    }
}
