using System;
using Calculator;
using System.Collections.Generic;
namespace MathBlasterGame
{




    public class GameConsoleUI
    {
        public string ConsoleUiOperator { get; private set; }
        public GameConsoleUI()
        {
           // var calc = new Operators();
        }

        public const int _numberOfChoices = 6;
        public void WelcomeMessage()
        {
            Console.WriteLine("Welcome to Math Blaster!");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
        }

        
        public void DisplayExpression(int operandx, int operandy, OperatorsList operatorParam)
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
            Console.WriteLine($"The Expression is {operandx} {ConsoleUiOperator} {operandy}");
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
