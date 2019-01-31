using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_calculator
{
    public class CalculatorEngine
    {
        public double Calculate(double firstNumber, double secondNumber, string operation)
        {
            double result;

            switch(operation.ToLower()) //case insensitivity
            {
                case "add":
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "subtract":
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "multiply":
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "divide":
                case "/":
                    result = firstNumber / secondNumber;
                    break;
                default:
                    throw new InvalidOperationException("Operation is not recognized");
            }

            return result;
        }
    }
}
