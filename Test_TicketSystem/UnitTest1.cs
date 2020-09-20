using System.ComponentModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System;


namespace Test_TicketSystem
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_PriceMethod240kr()
        {
            // Arrange - Creating the object  we will use for test
            var car = new Car();

            // Act - call the method at object we will be testing
            double price = car.Price();

            // Assert -  test the value if is correct (Assert class is static)
            Assert.AreEqual(240,price);

        }


        [TestMethod]
        public void Test_VehicleType()
        {
            var vehicle = new Car();

            string VehicleType = vehicle.VehicleType();

            Assert.AreEqual("Car",VehicleType);

        }




    }
}
