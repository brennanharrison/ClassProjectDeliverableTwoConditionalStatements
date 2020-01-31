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
            // Write a string to the console.
            Console.WriteLine("Hello!"); 

            // Ask the user for a number.
            Console.WriteLine("Enter the number of the grade you expect to earn in ISM 4390!");

            // Read the user's input.
            string input = Console.ReadLine(); 

           try // Execute this block if the input is an integer.
            {
                // Parse the input to a string.
                int grade = Int32.Parse(input); 

                // Test if the grade is beyond 100.
                if (grade > 100)
                {
                    Console.WriteLine("You must enter a number between 0 and 100!");
                }

                // Test if the grade is an A+.
                else if (grade >= 98 && grade <= 100) 
                {
                    Console.WriteLine("A+");
                }

                // Test if the grade is an A.
                else if (grade < 98 && grade >=92) 
                {
                    Console.WriteLine("A");
                }

                // Test if the grade is an A-.
                else if (grade >= 90 && grade <= 91) 
                {
                    Console.WriteLine("A-");
                }

                // Test if the grade is a B+.
                else if (grade < 90 && grade >=88) 
                {
                    Console.WriteLine("B+");
                }

                // Test if the grade is a B.
                else if (grade >= 82 && grade <= 87) 

                {
                    Console.Write("B");
                }

                // Test if the grade is a B-.
                else if (grade <= 81 && grade >= 80) 
                {
                    Console.WriteLine("B-");
                }

                // Test if the grade is a C+.
                else if (grade <= 79 && grade >= 78) 
                {
                    Console.WriteLine("C+");
                }

                // Test if the grade is a C.
                else if (grade <= 77 && grade >= 72) 
                {
                    Console.WriteLine("C");
                }

                // Test if the grade is a C-.
                else if (grade <= 71 && grade >= 70) 
                {
                    Console.WriteLine("C-");
                }

                // Test if the grade is a D+.
                else if (grade <= 69 && grade >= 68) 
                {
                    Console.WriteLine("D+");
                }

                // Test if the grade is a D.
                else if (grade <= 67 && grade >= 62) 
                {
                    Console.WriteLine("D");
                }

                // Test if the grade is a D-.
                else if (grade <= 61 && grade >= 60) 
                {
                    Console.WriteLine("D-");
                }

                // Anything lower is an F.
                else
                {
                    Console.WriteLine("F");
                }
            }

            // Execute if the string cannot be parsed in an integer.
            catch
            {
                // Write that the integer must be positive and not contain any non-numeric characters.
                Console.WriteLine("You must enter a positive integer for your grade!");
            }
        }
    }
}
