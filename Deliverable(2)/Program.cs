/* 
Author: Khushbu Patel
Date: 1/21/2023
Decription: This is a C# Console Application for calculating letter grades
*/

using System;

namespace Deliverable_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What grade do you expect in ISM 4300?");
            Console.WriteLine("Enter a numeric grade: ");

            try
            {
                decimal grade = decimal.Parse(Console.ReadLine());

                string letter;

                if (grade >= 90)
                {
                    letter = "A";
                    Console.WriteLine("Your expected letter grade in ISM 4300 is " + letter + ".");
                }

                else if (grade >= 80 && grade < 90)
                {
                    letter = "B";
                    Console.WriteLine("Your expected letter grade in ISM 4300 is " + letter + ".");
                }
                else if (grade >= 70 && grade < 80)
                {
                    letter = "C";
                    Console.WriteLine("Your expected letter grade in ISM 4300 is " + letter + ".");
                }
                else if (grade >= 60 && grade < 70)
                {
                    letter = "D";
                    Console.WriteLine("Your expected letter grade in ISM 4300 is " + letter + ".");
                }
                else
                {
                    letter = "F";
                    Console.WriteLine("Your expected letter grade in ISM 4300 is " + letter + ".");
                }
            }
            catch
            {
                Console.WriteLine("Please enter a numeric value");
            }
        }
    }
}