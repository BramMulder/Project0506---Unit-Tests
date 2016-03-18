using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project0506.CsvObjects
{
    class Monitoring
    {
        public string UnitID { get; set; }
        public string BeginDateTime { get; set; }
        public string EndDateTime { get; set; }
        public string BeginDate { get; set; }
        public string EndDate { get; set; }
        public string BeginTime { get; set; }
        public string EndTime { get; set; }
        public string Type { get; set; }
        public string Min { get; set; }
        public string Max { get; set; }
        public string Sum { get; set; }
    }
}
