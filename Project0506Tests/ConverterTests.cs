using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using System.Globalization;

namespace Project0506.Tests
{
    [TestClass()]
    public class ConverterTests
    {
        [TestMethod()]
        public void ConvertToLatLongTest()
        {
            //Input Values
            double rdX = 158126.102542985;
            double rdY = 380446.027478599;

            //Expected Values (Converted at http://www.gpscoordinaten.nl/converteer-rd-coordinaten.php)
            double expectedLonglitude = 51.413135543925;
            double expectedLattitude = 5.43213848385869;

            //Method call
            string result = Converter.ConvertToLatLong(rdX, rdY);

            //Response (Longitude Lattitute) is in {0}{1} String format, so needs to be split
            string[] results = result.Split();

            //Creates variables and parses String results into doubles
            double longitude = double.Parse(results[0], CultureInfo.InvariantCulture.NumberFormat);
            double lattitude = double.Parse(results[1], CultureInfo.InvariantCulture.NumberFormat);

            //Prints out the values
            Trace.WriteLine("long: " + longitude + " lat: " + lattitude);

            //Checks if the calculated values match the expected values
            //The test has passed if this boolean condition is true
            Assert.IsTrue((expectedLonglitude == longitude) && (expectedLattitude == lattitude));
        }

        [TestMethod()]
        public void convertDateTimeConnectionsTest()
        {
            //Create an Object of connections
            CsvObjects.Connections connections = new CsvObjects.Connections();
           
            //Insert a value into the "DateTime" variable of connections
            connections.DateTime = "10-3-2015 00:47";
            
            //Add the connections object to connectionsList in the class "MainClass"
            MainClass.connectionsList.Add(connections);
            
            //Call the method
            Converter.convertDateTimeConnections();

            //Retrieve the object from the arraylist in the class "MainClass" 
            //Create a local object (to be able to acces the values)
            CsvObjects.Connections obj1 = (CsvObjects.Connections)MainClass.connectionsList[0];

            //Prints out the values
            Trace.WriteLine("Date: " + obj1.Date + " Time: " + obj1.Time);

            //Checks if the split values match the expected values
            //The test has passed if this boolean condition is true
            Assert.IsTrue((obj1.Date.Equals("10-3-2015")) && (obj1.Time.Equals("00:47")));
        }
    }
}