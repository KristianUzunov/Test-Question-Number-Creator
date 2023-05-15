using System;
using System.ComponentModel;
using System.Linq;

namespace emptyQuestionSpaceMaker
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            bool isInt = true;
            bool letPass = false;
            int numberToTestCuzImTooStupidToThinkOfAnotherWayToDoThis = 0;
            string continueQuestion = "1";
            while (continueQuestion != "STOP")
            {
                Console.WriteLine("Input number of questions on the test.");
                string numberOfQuestions = Console.ReadLine();
                numberToTestCuzImTooStupidToThinkOfAnotherWayToDoThis = 0;
                letPass = false;
                while (letPass == false)
                {
                    isInt = true;
                    foreach (var thing in numberOfQuestions)
                    {
                        if (char.IsLetter(thing) || thing == '.' || thing == ' ')
                        {
                            isInt = false;
                            Console.WriteLine("Please use a whole digit.");
                            numberOfQuestions = Console.ReadLine();
                            break;
                        }
                        if (isInt == true && numberToTestCuzImTooStupidToThinkOfAnotherWayToDoThis == numberOfQuestions.Length)
                        {
                            letPass = true;
                        }
                        numberToTestCuzImTooStupidToThinkOfAnotherWayToDoThis++;
                    }
                }
                for (int i = 1; i <= int.Parse(numberOfQuestions); i++)
                {
                    Console.WriteLine($"{i} - ");
                }
                Console.WriteLine("Type anything to continue or type STOP to exit the application.");
                continueQuestion = Console.ReadLine();
            }
        }
    }
}
