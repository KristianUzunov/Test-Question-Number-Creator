using System;
using System.ComponentModel;
using System.Linq;

namespace emptyQuestionSpaceMaker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number of questions on the test.");
            string numberOfQuestions = Console.ReadLine();
            bool isInt = true;
            bool letPass = false;
            int numberToTestCuzImTooStupidToThinkOfAnotherWayToDoThis = 0;
            while (letPass == false) 
            {
                isInt = true;
                foreach (var thing in numberOfQuestions)
                {
                    if (char.IsLetter(thing) || thing == '.')
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
        }
    }
}
