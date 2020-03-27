using System;
using Calculator;

namespace MathBlasterGame
{
    class Program
    {
        static void Main(string[] args)
        {
            GameConsoleUi.WelcomeMessage();
           
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            var problemNumber = 1;
            while (keyInfo.Key != ConsoleKey.Escape)
            {
                //TestingDebugMethod();
                var gl = new GameConsoleUi();
                var operators = new Operators();

                operators.GetOperands();


               

                gl.DisplayExpression(problemNumber, operators.OperandX, operators.OperandY, operators.Operator);
                var shuffledUpChoices = operators.Shuffle(operators.ChoiceGenerator());
                // Proving that shuffleupchoices will consistently display items in same order. shuffledUpChoices.ForEach(Console.WriteLine);
            
            
                gl.DisplayOptions(shuffledUpChoices);
                
                //call game logic, readkey to stop
                var userschoice = Console.ReadKey();
                var glc = new GameLogicConsole(operators.ExpressionSolution, shuffledUpChoices);
                ConsoleKey thing = glc.ProcessUserChoice(userschoice);
                
                Console.WriteLine(" ");
                Console.WriteLine("Press Enter for next problem. Escape to quit.");
                problemNumber++;
                keyInfo = Console.ReadKey();
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
