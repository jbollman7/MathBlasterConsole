using System;
using System.Collections.Generic;

namespace MathBlasterGame
{
    public class GameLogicConsole
    {
        public  ConsoleKey CorrectKey { get; private set; }


        public GameLogicConsole(int expressionAnswer, IReadOnlyList<int> expressionChoices)
        {
            CorrectKeyToExpressionAnswer(expressionAnswer, expressionChoices);
        }
       
        public  void ProcessUserChoice(ConsoleKeyInfo userchoice )
        {
            var input = userchoice;
            
            switch (input.Key) //Switch on Key enum
            {
                case ConsoleKey.A:
                    if (ConsoleKey.A == CorrectKey)
                    {
                        CorrectAnswer();
                    }

                    else   
                    {
                        WrongAnswer();
                    }
                    break;
                case ConsoleKey.B:
                    if (ConsoleKey.B == CorrectKey)
                    {
                        CorrectAnswer();
                    }

                    else   
                    {
                        WrongAnswer();
                    }
                    break;
                case ConsoleKey.C:
                    if (ConsoleKey.C == CorrectKey)
                    {
                        CorrectAnswer();
                    }

                    else   
                    {
                        WrongAnswer();
                    }
                    break;
                case ConsoleKey.D:
                    if (ConsoleKey.D == CorrectKey)
                    {
                        CorrectAnswer();
                    }

                    else   
                    {
                        WrongAnswer();
                    }
                    break;
                case ConsoleKey.E:
                    if (ConsoleKey.E == CorrectKey)
                    {
                        CorrectAnswer();
                    }

                    else   
                    {
                        WrongAnswer();
                    }
                    break;
                case ConsoleKey.F:
                    if (ConsoleKey.F == CorrectKey)
                    {
                        CorrectAnswer();
                    }

                    else   
                    {
                        WrongAnswer();
                    }
                    break;
                case ConsoleKey.Escape:
                    break;
                
                case ConsoleKey.Enter:
                    break;
                
                default:
                    Console.WriteLine("Choices are A-F, Esc, and Enter. Please try again.");
                    break;
            }
            
        }

        private void CorrectKeyToExpressionAnswer(int expressionAnswer, IReadOnlyList<int> expressionChoices)
        {
            int canidateAnswer = 0;
            for (int option = 0; option < expressionChoices.Count; option++)
            {
                canidateAnswer = expressionChoices[option];
                if (canidateAnswer == expressionAnswer)
                {
                    canidateAnswer = option;
                    break;
                }
            }

            switch (canidateAnswer)
            {
                case 0:
                    CorrectKey = ConsoleKey.A;
                    break;
                case 1:
                    CorrectKey = ConsoleKey.B;
                    break;
                case 2:
                    CorrectKey = ConsoleKey.C;
                    break;
                case 3:
                    CorrectKey = ConsoleKey.D;
                    break;
                case 4:
                    CorrectKey = ConsoleKey.E;
                    break;
                case 5:
                    CorrectKey = ConsoleKey.F;
                    break;
                
            }
           
        }

        public  void CorrectAnswer()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Correct Answer, good job");
        }
        public static void WrongAnswer()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Wrong Answer, sorry");
        }


        //Answer was right method
        // Answer was wrong method

    }
}