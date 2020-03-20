using System;
using Calculator;

namespace MathBlasterGame
{
    class Program
    {
        static void Main(string[] args)
        {
           var operators = new Operators();
            Console.WriteLine(operators.GetOperator());
        }
    }
}
