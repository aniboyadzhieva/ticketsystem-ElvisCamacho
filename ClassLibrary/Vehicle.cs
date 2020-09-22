using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    /// <summary>
    /// all the class will inherited from this vehicle class
    /// </summary>
    public abstract class Vehicle
    { 
        private string brobizzDiscount;
        private DateTime date;

        /// <summary>
        /// default Vehicle constructor
        /// </summary>
        public Vehicle()
        {
        }

        /// <summary>
        /// Vehicle constructor - includes the functionality about the length of the license plate
        /// </summary>
        /// <param name="licensePlate"></param>
        /// <param name="brobizzDiscount"></param>
        public Vehicle(string licensePlate, bool brobizzDiscount, DateTime date)
        {
            
        }

        
        public bool BrobizzDiscount { get; set; }
        public DateTime Date { get; set; }


        /// <summary>
        /// Price method
        /// </summary>
        /// <returns>double 240</returns>
        public virtual double Price()
        {
            return 240;
        }

        public void LicensePlate( string licensePlate)
        {
            if (licensePlate.Length > 8)
                throw new ArgumentException("License plate must not contain more than 8 characters");
        }


        /// <summary>
        /// BrobizzDiscountMethod method
        /// </summary>
        /// <returns>price with discount or the default one</returns>
        public double BrobizzDiscountMethod()
        {
            if (BrobizzDiscount)
            {
                return Price() * 0.95;
            }
            return Price();
        }

        /// <summary>
        /// VehicleType method - only overrides are used
        /// </summary>
        /// <returns></returns>
        public abstract string VehicleType();
    }
}
