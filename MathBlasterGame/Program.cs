using System;
using Calculator;

namespace MathBlasterGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestingDebugMethod();
           
            var gl = new GameConsoleUI();
            var operators = new Operators();
            
            operators.GetOperands();
            
            Console.WriteLine($"X has been set to {operators.OperandX}");
            Console.WriteLine($"Y has been set to {operators.OperandY}");
            Console.WriteLine($"{operators.Operator}");
            Console.WriteLine($"Answer is {operators.ExpressionSolution}");

            gl.WelcomeMessage();
            gl.DisplayExpression(operators.OperandX, operators.OperandY, operators.Operator);
            gl.DisplayOptions(operators.Shuffle(operators.ChoiceGenerator()));
            
        }
        static public void TestingDebugMethod()
        {
            var operators = new Operators();
            /*
            operators.GetOperands();
            Console.WriteLine($"Operator is {operators.Operator}");
            Console.WriteLine($"X has been set to {operators.OperandX}");
            Console.WriteLine($"Y has been set to {operators.OperandY}");
            */
            operators.GetOperands();
            Console.WriteLine($"X has been set to {operators.OperandX}");
            Console.WriteLine($"Y has been set to {operators.OperandY}");

            Console.WriteLine($"{operators.Operator}");
            Console.WriteLine(operators.IsItAInt());
            //Console.WriteLine(operators.GetOperator());
            while (!(operators.IsItAInt()))
            {
                operators.GetOperands();
            }
            Console.WriteLine($"X has been set to {operators.OperandX}");
            Console.WriteLine($"Y has been set to {operators.OperandY}");
            Console.WriteLine($"Answer is {operators.ExpressionSolution}");
            Console.WriteLine($"{operators.Operator}");
            Console.WriteLine(operators.IsItAInt());
            var mylist = operators.ChoiceGenerator();

            mylist.ForEach(Console.WriteLine);

            var shuff = operators.Shuffle(operators.ChoiceGenerator());
            Console.WriteLine(" Shuffle list below");
            shuff.ForEach(Console.WriteLine);

        }
    }
}
