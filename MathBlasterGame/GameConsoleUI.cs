using System;
using Calculator;
using System.Collections.Generic;
namespace MathBlasterGame
{




    public class GameConsoleUi
    {
        public string ConsoleUiOperator { get; private set; }
        public GameConsoleUi()
        {
           // var calc = new Operators();
        }

        public const int NumberOfChoices = 6;
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to Math Blaster!");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Press Enter to begin, Esc to quit");
        }

        
        public void DisplayExpression(int problemNumber, int operandx, int operandy, OperatorsList operatorParam)
        {
            switch (operatorParam)
            {
                case OperatorsList.Addition:
                    ConsoleUiOperator = "+";
                    break;
                
                case OperatorsList.Subtraction:
                    ConsoleUiOperator = "-";
                    break;
                
                case OperatorsList.Multiplication:
                    ConsoleUiOperator = "*";
                    break;
                
                case OperatorsList.Division:
                    ConsoleUiOperator = "/";
                    break;
            }
            Console.WriteLine($"Problem {problemNumber}:  {operandx} {ConsoleUiOperator} {operandy}");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
        }

        public void DisplayOptions(List<int> possibleChoices)
        {
            Console.Write($"A) {possibleChoices[0]}");
            Console.Write($"\t \t B) {possibleChoices[1]}");
            Console.WriteLine($"\t \t C) {possibleChoices[2]}");
            Console.WriteLine(" ");
            Console.Write($"D) {possibleChoices[3]}");
            Console.Write($"\t \t E) {possibleChoices[4]}");
            Console.Write($"\t \t F)  {possibleChoices[5]}");

        }

        
    }
}
