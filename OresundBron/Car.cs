using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary;

namespace OresundBron
{
    public class Car : Vehicle
    {
        /// <summary>
        /// Price method
        /// </summary>
        /// <returns> 410kr  </returns>
        public override double Price()
        {
            return 410;
        }

        /// <summary>
        /// Price with Brobizz agreement
        /// </summary>
        /// <returns> 161kr </returns>
        public double BrobizzAgreement()
        {
            return 161;
        }

        /// <summary>
        /// VehicleType method 
        /// </summary>
        /// <returns> a string MC </returns>
        public override string VehicleType()
        {
            return "Oresund car";
        }

        
    }
}
