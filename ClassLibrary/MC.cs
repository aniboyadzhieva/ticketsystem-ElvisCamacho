using System;

namespace ClassLibrary
{
    /// <summary>
    /// This is a MC Class
    /// </summary>
    public class MC
    {
        public string LicensePlate { get; set; }
        public DateTime Date { get; set; }

        /// <summary>
        /// Price method
        /// </summary>
        /// <returns> 125kr </returns>
        public double Price()
        {
            return 125;
        }
        /// <summary>
        /// VehicleType method 
        /// </summary>
        /// <returns> a string MC </returns>
        public string VehicleType()
        {
            return "MC";
        }




    }

}
