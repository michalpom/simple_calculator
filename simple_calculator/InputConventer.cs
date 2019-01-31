using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_calculator
{
    public class InputConventer
    {
        public double ConvertInputToNumeric(string TextInput)
        {
            double convenrtedNumber;

            if(!double.TryParse(TextInput, out convenrtedNumber))
            {
                throw new ArgumentException("Excepted a numeric value"); //throwing exception if the input is not valid
            }

            return convenrtedNumber;
        }
    }
}
