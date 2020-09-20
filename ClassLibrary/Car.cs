using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    /// <summary>
    /// This is a CAR Class
    /// </summary>
    public class Car
    {
        public string LicensePlate { get; set; }
        public DateTime Date { get; set; }

        /// <summary>
        /// Price method
        /// </summary>
        /// <returns> 240kr</returns>
        public double Price()
        {
            return 240;
        }
        /// <summary>
        /// VehicleType method 
        /// </summary>
        /// <returns> a string car </returns>
        public string VehicleType()
        {
            return "Car";
        }




    }
}
