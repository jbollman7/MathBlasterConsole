using System;
using Calculator;

namespace MathBlasterGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //ConsoleKeyInfo keyInfo = Console.ReadKey();
            while (true)
            {
                //TestingDebugMethod();
           
                var gl = new GameConsoleUI();
                var operators = new Operators();
                
            
                operators.GetOperands();


                gl.WelcomeMessage();
                gl.DisplayExpression(1, operators.OperandX, operators.OperandY, operators.Operator);
                var shuffledUpChoices = operators.Shuffle(operators.ChoiceGenerator());
                // Proving that shuffleupchoices will consistently display items in same order. shuffledUpChoices.ForEach(Console.WriteLine);
            
            
                gl.DisplayOptions(shuffledUpChoices);
                
                //call game logic, readkey to stop
                var userschoice = Console.ReadKey();
                var glc = new GameLogicConsole(operators.ExpressionSolution, shuffledUpChoices);
                glc.ProcessUserChoice(userschoice);

                Console.WriteLine("Press Enter for next problem");
                var nextProblem = Console.ReadKey();
                if (nextProblem.Key == ConsoleKey.Enter)
                {
                    continue;
                }

                else if (nextProblem.Key == ConsoleKey.Escape)
                {
                    break;
                }

            }
            


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
