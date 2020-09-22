using System.ComponentModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System;
using OresundBron;


namespace Test_TicketSystem
{
    [TestClass]
    public class CarClass_Test
    {
        [TestMethod]
        public void Test_PriceMethod240kr()
        {
            // Arrange - Creating the object  we will use for test
            var car = new ClassLibrary.Car();

            // Act - call the method at object we will be testing
            double price = car.Price();

            // Assert -  test the value if is correct (Assert class is static)
            Assert.AreEqual(240, price);

        }


        [TestMethod]
        public void Test_Car_VehicleType()
        {
            var vehicle = new ClassLibrary.Car();

            string VehicleType = vehicle.VehicleType();

            Assert.AreEqual("Car", VehicleType);

        }

        [TestMethod]
        public void Test_PriceMethod125kr()
        {
            // Arrange - Creating the object  we will use for test
            var car = new ClassLibrary.MC();

            // Act - call the method at object we will be testing
            double price = car.Price();

            // Assert -  test the value if is correct (Assert class is static)
            Assert.AreEqual(125,price);

        }


        [TestMethod]
        public void Test_Mc_VehicleType()
        {
            var mc = new ClassLibrary.MC();

            string VehicleType = mc.VehicleType();

            Assert.AreEqual("MC", VehicleType);

        }


        [TestMethod]
        public void Test_licensePlate()
        {
            Vehicle vehicle = new ClassLibrary.Car();

            try
            {
                vehicle.LicensePlate("12345678");
            }
            catch (System.ArgumentException)
            {
                Assert.Fail();
            }
        }

        //***************************** OresundsBron CAR test ****************************


        [TestMethod]
        public void Test_OresundsBronPrice()
        {
            OresundBron.Car c = new OresundBron.Car();

            int expected = 410;
            var result = c.Price();


            Assert.AreEqual(expected,result);
        }


        [TestMethod]
        public void Test_OresundsBronVehicleType()
        {
            OresundBron.Car c = new OresundBron.Car();

            string expected = "Oresund car";
            var result = c.VehicleType();


            Assert.AreEqual(expected,result);
        }


        [TestMethod]
        public void Test_OresundsBronBrobizzAgreement()
        {
            OresundBron.Car c = new OresundBron.Car();

            double expected = 161;
            var result = c.BrobizzAgreement();


            Assert.AreEqual(expected,result);
        }



        //***************************** OresundsBron MC test ****************************


        [TestMethod]
        public void Test_OresundsBronMcPrice()
        {
            OresundBron.MC c = new OresundBron.MC();

            int expected = 210;
            var result = c.Price();


            Assert.AreEqual(expected,result);
        }


        [TestMethod]
        public void Test_OresundsBronMcVehicleType()
        {
            OresundBron.MC c = new OresundBron.MC();

            string expected = "Oresund MC";
            var result = c.VehicleType();


            Assert.AreEqual(expected,result);
        }


        [TestMethod]
        public void Test_OresundsBronMcBrobizzAgreement()
        {
            OresundBron.MC c = new OresundBron.MC();

            double expected = 73;
            var result = c.BrobizzAgreement();


            Assert.AreEqual(expected,result);
        }

    }
}
