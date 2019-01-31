using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                InputConventer inputConventer = new InputConventer(); //converts from string to numerical data
                CalculatorEngine calculatorEngine = new CalculatorEngine();

                //converting user's input to numeric
                double firstNumber = inputConventer.ConvertInputToNumeric(Console.ReadLine());
                double secondNumber = inputConventer.ConvertInputToNumeric(Console.ReadLine());

                string operation = Console.ReadLine(); //operation

                double result = calculatorEngine.Calculate(firstNumber, secondNumber, operation);

                Console.WriteLine(result);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

}
