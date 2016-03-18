using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project0506.CsvObjects
{
    class Positions
    {
        public string DateTime { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string UnitID { get; set; }
        public string Rdx { get; set; }
        public string Rdy { get; set; }
        public string Longitude { get; set; }
        public string Lattitude { get; set; }
        public string Speed { get; set; }
        public string Course { get; set; }
        public string NumSatellites { get; set; }
        public string HDOP { get; set; }
        public string Quality { get; set; }
    }
}
