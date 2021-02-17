using System;

namespace Prerequisite

class Program

   

    static void Main(string[] args)
        {   
            var keepAlive = true;
            while (keepAlive)
            {
        try
        {
            Console.Write("Enter assignment number (or -1 to exit): ");
            var assignmentChoice = int.Parse(Console.ReadLine() ?? "");
            Console.ForegroundColor = ConsoleColor.Green;
            switch (assignmentChoice)
            {
                case 1:
                    RunExerciseOne();
                    break;
                case 2:
                    RunExerciseTwo();
                    break;
                case 3:
                    // Call your next assignment method here!
                    break;
                case -1:
                    keepAlive = false;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That is not valid assignment number!");
                    break;

            }
            Console.ResetColor();
            Console.WriteLine("Hit any key to continue!");
            Console.ReadKey();
            Console.Clear();

        }
        catch
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("That is not valid assignment number!");
            Console.ResetColor();
        }
        
        private static void RunExerciseOne();
        {
            Console.WriteLine("You successfully ran exercise one!");
        }

        private static void RunExerciseTwo();
        {
            Console.WriteLine("You successfully ran exercise two!");
        }