using System;

namespace Calculator
{
    public enum OperatorsList
    {
        Addition,
        Subtraction,
        Multiplication,
        Division
    }
    public class Operators
    {
        public static int Add(int x, int y) => x + y;
        public static int Subtract(int x, int y) => x - y;
        public static int Multiplication(int x, int y) => x * y;
        public static int Division(int x, int y) => x / y;


        public OperatorsList GetOperator()
        {
            var values = Enum.GetValues(typeof(OperatorsList));
            var random = new Random();
            var randomOperator = (OperatorsList)values.GetValue(random.Next(values.Length));
            return randomOperator;
        }
    }
}
