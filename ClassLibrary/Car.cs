using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    /// <summary>
    /// This is a CAR Class
    /// </summary>
    public abstract class Car
    {
        public string LicensePlate { get; set; }
        public DateTime Date { get; set; }

        /// <summary>
        /// Price method
        /// </summary>
        /// <returns> 240kr</returns>
        public virtual double Price()
        {
            return 240;
        }
        /// <summary>
        /// VehicleType method 
        /// </summary>
        /// <returns> a string car </returns>
        public virtual string VehicleType()
        {
            return "Car";
        }




    }
}
