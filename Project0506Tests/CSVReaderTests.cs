using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project0506.CsvObjects;
using System.Collections;
using System.Diagnostics;

namespace Project0506.Tests
{
    [TestClass()]
    public class CSVReaderTests
    {
        [TestMethod()]
        public void readConnectionsTest()
        {
            //Expected Values First Line
            string DateTime = "2015-03-10 00:47:24";
            string UnitId = "357566040024266";
            string Port = "Connection";
            string Value = "1";

            //Expected Values Last Line
            string DateTimeLast = "2015-03-19 23:59:54";
            string UnitIdLast = "357566000058114";
            string PortLast = "Connection";
            string ValueLast = "1";

            //Create a Local ArrayList to store the returned ArrayList
            ArrayList connectionsList = new ArrayList();

            //Call the "readConnections" method in the "CSVReader" class
            connectionsList = CSVReader.readConnections();

            //Create a local object (to be able to acces the values)
            Connections obj1 = (Connections)connectionsList[0];
            Connections obj2 = (Connections)connectionsList[connectionsList.Count-1];

            //Print values
            Trace.WriteLine("DateTime: " + obj1.DateTime + " UnitId: " + obj1.UnitID + " Port: " + obj1.Port + " Value: " + obj1.Value);
            Trace.WriteLine("DateTime: " + obj2.DateTime + " UnitId: " + obj2.UnitID + " Port: " + obj2.Port + " Value: " + obj2.Value);

            // Checks if the read values match the expected values
            //The test has passed if this boolean condition is true
            Assert.IsTrue(     (obj1.DateTime.Equals(DateTime)) 
                            && (obj1.UnitID.Equals(UnitId)) 
                            && (obj1.Port.Equals(Port)) 
                            && (obj1.Value.Equals(Value)));

            Assert.IsTrue(     (obj2.DateTime.Equals(DateTimeLast))
                            && (obj2.UnitID.Equals(UnitIdLast))
                            && (obj2.Port.Equals(PortLast))
                            && (obj2.Value.Equals(ValueLast)));
        }
    }
}