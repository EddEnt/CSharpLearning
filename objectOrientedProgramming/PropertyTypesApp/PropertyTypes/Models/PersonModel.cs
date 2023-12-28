using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyTypes.Models
{
    public class PersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private int _age;

        public int Age
        {
            get { return _age; }
            set 
            {
                if(value >= 0 && value < 126)
                {
                    _age = value; 
                }
                else
                {
                    throw new ArgumentOutOfRangeException("value", "Age must be in a valid range.");
                }

            }
        }

        private string _sin;

        public string SIN
        {
            get 
            {
                string sinOutput = "***-***-*" + _sin.Substring(_sin.Length - 2) ;
                return sinOutput; 
            }
            set { _sin = value; }
        }


    }
}
