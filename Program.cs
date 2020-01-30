// Author: Brennan Harrison
// Date: 01/28/2019
// Assignment: Class Project Deliverable Two Conditional Statements

using System;

namespace ClassProjectDeliverableTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!"); // Write a string to the console.
            Console.WriteLine("Enter the number of the grade you expect to earn in ISM 4390!");
            string input = Console.ReadLine(); // Read the user's input.

           try // Execute this block if the input is an integer.
            {
                int grade = Int32.Parse(input); // Parse the input to a string.

                if (grade > 100)
                {
                    Console.WriteLine("You must enter a number between 1 and 100!");
                }
                else if (grade >= 98 && grade <= 100) // Test if the grade is an A+.
                {
                    Console.WriteLine("A+");
                }
                
                else if (grade < 98 && grade >=92) // Test if the grade is an A.
                {
                    Console.WriteLine("A");
                }

                else if (grade >= 90 && grade <= 91) // Test if the grade is an A-.
                {
                    Console.WriteLine("A-");
                }

                else if (grade < 90 && grade >=88) // Test if the grade is a B+.
                {
                    Console.WriteLine("B+");
                }

                else if (grade >= 82 && grade <= 87) // Test if the grade is a B.

                {
                    Console.Write("B");
                }

                else if (grade <= 81 && grade >= 80) // Test if the grade is a B-.
                {
                    Console.WriteLine("B-");
                }

                else if (grade <= 79 && grade >= 78) // Test if the grade is a C+.
                {
                    Console.WriteLine("C+");
                }

                else if (grade <= 77 && grade >= 72) // Test if the grade is a C.
                {
                    Console.WriteLine("C");
                }

                else if (grade <= 71 && grade >= 70) // Test if the grade is a C-.
                {
                    Console.WriteLine("C-");
                }

                else if (grade <= 69 && grade >= 68) // Test if the grade is a D+.
                {
                    Console.WriteLine("D+");
                }

                else if (grade <= 67 && grade >= 62) // Test if the grade is a D.
                {
                    Console.WriteLine("D");
                }

                else if (grade <= 61 && grade >= 60) // Test if the grade is a D-.
                {
                    Console.WriteLine("D-");
                }

                else // Anything lower is an F.
                {
                    Console.WriteLine("F");
                }
            }
            catch // Execute if the string cannot be parsed in an integer.
            {
                Console.WriteLine("You must enter a positive integer for your grade!");
            }
        }
    }
}
