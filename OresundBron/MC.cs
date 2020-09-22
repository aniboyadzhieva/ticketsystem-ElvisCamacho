using System;
using ClassLibrary;

namespace OresundBron
{
    public class MC : Vehicle
    {

        public MC()
        {
            
        }
        /// <summary>
        /// Price method
        /// </summary>
        /// <returns> 210kr </returns>
        public override double Price()
        {
            return 210;
        }

        /// <summary>
        /// Price with Brobizz agreement
        /// </summary>
        /// <returns> 73kr </returns>
        public double BrobizzAgreement()
        {
            return 73;
        }

        /// <summary>
        /// VehicleType method 
        /// </summary>
        /// <returns> a string MC </returns>
        public override string VehicleType()
        {
            return "Oresund MC";
        }
    }
}
