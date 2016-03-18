using System;
using System.IO;
using System.Collections;

namespace Project0506
{
    /// <summary>
    /// Reads CSVFiles with a String reader and puts the info into objects
    /// </summary>
    public class CSVReader
    {
        /// <summary>
        /// Splits at the Characters in the list
        /// </summary>
        private static char[] delimiters = new char[] { ';' };

        /// <summary>
        /// Reads the CSV, splits every line, splits the line a the defined character in "delimiters".
        /// Puts every part of the line in a Connections object and adds this object to an ArrayList
        /// </summary>
        /// <returns>An ArrayList with Connections objects</returns>
      public static ArrayList readConnections()
        {
            try
            {
                using (StreamReader reader = new StreamReader(@"..\Connections.CSV"))
                {
                    ArrayList connectionsList = new ArrayList();
                    CsvObjects.Connections connections;
                    string[] fields;

                    reader.ReadLine();

                    while (true)
                    {
                        //Breaks out when at the end
                        string line = reader.ReadLine();
                        if (line == null)
                        {
                            break;
                        }
                        //Splits the rows at the delimiters char
                        fields = line.Split(delimiters);

                        //Creates an object "Connections" and puts the read values into the object
                        connections = new CsvObjects.Connections();
                        connections.DateTime = fields[0];
                        connections.UnitID = fields[1];
                        connections.Port = fields[2];
                        connections.Value = fields[3];
                        connectionsList.Add(connections);
                    }
                    Console.WriteLine("done connections");
                    return connectionsList;
                }
            }
            catch (FileNotFoundException f)
            {
                Console.WriteLine("CSV-File not found", f.Message); ;
                return null;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e.StackTrace);
                return null;
            }
        }      
    }
}
