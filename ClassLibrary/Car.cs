using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Transactions;

namespace ClassLibrary
{
    /// <summary>
    /// This is a CAR Class
    /// </summary>
    public class Car
    {
        public DateTime Date { get; set; }

        public string LicensePlate {get; set;}

        public Car()
         : base()
        {
            
        }

        public Car(string licensePlate)
        {
            for (int i = 0; i > 7; i++)
            {
                if (licensePlate.Length > 7)
                {
                    throw new ArgumentException($"Invalid License Plate");
                }
                
            }
                
            
            
            LicensePlate = licensePlate;
        }


        /// <summary>
        /// Price method
        /// </summary>
        /// <returns> 240kr</returns>
        public virtual double Price()
        {
            return 250;
        }

        /// <summary>
        /// VehicleType method 
        /// </summary>
        /// <returns> a string car </returns>
        public virtual string VehicleType()
        {
            return $"Car";
        }






    }
}
