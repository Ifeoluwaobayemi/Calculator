using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Core.Logic
{
    public interface IOperations 
    {
        string Add(string firstNumber, string secondNumber);
        string Subtract(string firstNumber, string secondNumber);
        string Multiply(string firstNumber, string secondNumber);
        string Divide(string firstNumber, string secondNumber);
    }
}
