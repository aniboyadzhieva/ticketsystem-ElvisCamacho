using System;

namespace ClassLibrary
{
    /// <summary>
    /// This is a CAR Class
    /// </summary>
    public class Car : Vehicle
    {
        public DateTime Date { get; set; }
        public string LicensePlate { get; set; }

        public Car()
         : base()
        {

        }

        public Car(string licensePlate, bool brobizzDiscount, DateTime date) 
            : base(licensePlate, brobizzDiscount, date)
        {
        }

       
        /// <summary>
        /// Price method
        /// </summary>
        /// <returns> 240kr</returns>
        public override double Price()
        {
            return 240 ;
        }

        /// <summary>
        /// VehicleType method 
        /// </summary>
        /// <returns> a string car </returns>
        public override string VehicleType()
        {
            return $"Car";
        }

        
    }
}
