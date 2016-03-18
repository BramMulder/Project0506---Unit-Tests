using System;
using System.Collections;
using System.Globalization;
using System.Diagnostics;

namespace Project0506
{
    public class MainClass
    {
        public static ArrayList connectionsList = new ArrayList();

        public static void Main(string[] args)
        {
            connectionsList = CSVReader.readConnections();

            //Calls the converter method, which converts it into Lattitude and Longitude and splits the results
            //string result = Converter.ConvertToLatLong(rdX, rdY);
            //string[] results = result.Split();
            //Console.WriteLine(" result 1: " + results[0] + " result 2: " + results[1]);   
        }     
        
    }
}
