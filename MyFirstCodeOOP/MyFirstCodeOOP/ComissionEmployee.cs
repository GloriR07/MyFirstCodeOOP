using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstCodeOOP
{
    public class ComissionEmployee : Employee
    {
        #region properties
        public float ComissionPercentage  { get; set; }
        public decimal Sales { get; set; }

        #endregion

        #region Methods
        public override decimal GetValueToPay()
        {
            return Sales * (decimal)ConvertPercentage(ComissionPercentage);       
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\t Comission Percentage.....{ConvertPercentage(ComissionPercentage):P2}" +
                $"\n\t Sales....................{Sales:C2}" +
                $"\n\t Value To Pay.............{GetValueToPay():C2}";          
            
        }

        public float ConvertPercentage(float comissionPercentage)
        { 
            return (comissionPercentage/100); 
        }

        #endregion
    }
}
