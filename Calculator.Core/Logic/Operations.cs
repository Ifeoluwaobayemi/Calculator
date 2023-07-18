using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Core.Logic
{
    public class Operations
    {
        public string Add(string firstNumber, string secondNumber)
        {
            if (int.TryParse(firstNumber, out int value) && int.TryParse(secondNumber, out int value2))

            {
                return (value + value2).ToString();
            }
            else
            {
                return "Invalid number";
            }
            
        }
        public string Subtract(string firstNumber, string secondNumber)
        {
            if (int.TryParse(firstNumber, out int value) && int.TryParse(secondNumber, out int value2))
            {
                return (value - value2).ToString();
            }
            else
            {
                return "Invalid number";
            }
        }
        public string Multiply(string firstNumber, string secondNumber)
        {
            if (int.TryParse(firstNumber, out int value) && int.TryParse(secondNumber, out int value2))
            {
                return (value * value2).ToString();
            }
            else
            {
                return "Invalid number";
            }
        }
        public string Divide(string firstNumber, string secondNumber)
        {
            if (int.TryParse(firstNumber, out int value) && int.TryParse(secondNumber, out int value2))
            {
                return (value / value2).ToString();
            }
            else
            {
                return "Invalid number";
            }
        }


    }
}
