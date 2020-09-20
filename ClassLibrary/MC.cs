using System;
using System.Transactions;

namespace ClassLibrary
{
    /// <summary>
    /// This is a MC Class
    /// </summary>
    public class MC : Car
    {
        public string LicensePlate { get; set; }
        public DateTime Date { get; set; }

        /// <summary>
        /// Price method
        /// </summary>
        /// <returns> 125kr </returns>
        public override double Price()
        {
            return 125;
        }
        /// <summary>
        /// VehicleType method 
        /// </summary>
        /// <returns> a string MC </returns>
        public override string VehicleType()
        {
            return "MC";
        }
        
        public MC(string licensePlate) 
            : base(licensePlate)
        {
            LicensePlate = licensePlate;
        }

        public MC()
        {
        }
    }

}
