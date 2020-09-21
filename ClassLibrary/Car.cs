using System;

namespace ClassLibrary
{
    /// <summary>
    /// This is a CAR Class
    /// </summary>
    public class Car
    {
        public DateTime Date { get; set; }

        public string LicensePlate { get; set; }

        public Car()
         : base()
        {

        }

        public Car( string licensePlate)
        {
            LicensePlate = licensePlate;    
        }

        /// <summary>
        /// This METHOD check if the number plate is more than 7 characters
        /// </summary>
        /// <param name="licensePlate"></param>
        /// <returns> returns the number plate </returns>
        public virtual string NumberPlate(string licensePlate)
        {

            if (licensePlate.Length > 7)
            {
                throw new ArgumentException($"Invalid License Plate");
            }

            return licensePlate;
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
