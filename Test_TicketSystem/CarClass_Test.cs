using System.ComponentModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System;


namespace Test_TicketSystem
{
    [TestClass]
    public class CarClass_Test
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
        public void Test_Car_VehicleType()
        {
            var vehicle = new Car();

            string VehicleType = vehicle.VehicleType();

            Assert.AreEqual("Car",VehicleType);

        }

        [TestMethod]
        public void Test_PriceMethod125kr()
        {
            // Arrange - Creating the object  we will use for test
            var car = new MC();

            // Act - call the method at object we will be testing
            double price = car.Price();

            // Assert -  test the value if is correct (Assert class is static)
            Assert.AreEqual(125,price);

        }


        [TestMethod]
        public void Test_Mc_VehicleType()
        {
            var mc = new MC();

            string VehicleType = mc.VehicleType();

            Assert.AreEqual("MC",VehicleType);

        }


    }
}
