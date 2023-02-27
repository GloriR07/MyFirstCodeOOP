using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstCodeOOP
{
    public class BaseComissionEmployee : ComissionEmployee
    {
        #region Properties
        public decimal Base { get; set; }
        #endregion


        #region Methods
        //public override decimal GetValueToPay()
        //{        
        //    return ((Sales *(decimal)ConvertPercentage(ComissionPercentage)) + Base);
        //}

        public decimal NewGetValueToPay()
        {         
            return base.GetValueToPay() + Base;
        }
        public override string ToString()
        {
            return $"{base.ToString()}" +
                 $"\n\t Salary Base..............{Base:C2}" +
                 $"\n\t Value To Pay.............{NewGetValueToPay():C2}";
            #endregion
        }  
    
    }

}

