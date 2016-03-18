using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project0506.CsvObjects
{
    class OldCsvReader
    {

        static void readPositionsOld()
        {
            char[] delimiters = new char[] { ';' };
            using (StreamReader reader = new StreamReader(@"C:/Users/brems_000/Documents/Jaar 2/Project 0506/Positions.CSV"))
            {
                ArrayList positionsList = new ArrayList();
                CsvObjects.Positions positions;
                string[] fields;

                reader.ReadLine();
                while (true)
                {
                    string line = reader.ReadLine();
                    if (line == null)
                    {
                        break;
                    }
                    fields = line.Split(delimiters);

                    positions = new CsvObjects.Positions();
                    positions.DateTime = fields[0];
                    positions.UnitID = fields[1];
                    positions.Rdx = fields[2];
                    positions.Rdy = fields[3];
                    positions.Speed = fields[4];
                    positions.Course = fields[5];
                    positions.NumSatellites = fields[6];
                    positions.HDOP = fields[7];
                    positions.Quality = fields[8];
                    positionsList.Add(positions);

                }
                CsvObjects.Positions obj = (CsvObjects.Positions)positionsList[1342509];
                Console.WriteLine(obj.Rdx);
                Console.WriteLine("done positions");

            }
        }
    }
}
