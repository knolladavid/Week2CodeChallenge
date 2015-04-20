using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Code
{
    class Program
    {
        static void Main(string[] args)
        {



            for (int i = 0; i < 21; i++)
            {
                FizzBuzz(i);
            }
            LetterCounter('i', "I love biscuits and gravy. It's the best breakfast ever.");
            LetterCounter('n', "Never gonna give you up. Never gonna let you down.");
            LetterCounter('s', "Sally sells seashells down by the seashore. She's from Sussex.");

            Console.ReadKey();
        }
        static void FizzBuzz(int number)
        {
            if (number % 5 == 0 && number % 3 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (number % 3 == 0)
            {
                Console.WriteLine("Buzz");
            }
            if (number % 5 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else
            {
                Console.WriteLine(number);
            }
        }
        static void LetterCounter(char letter, string inString)
        {
            //
            //write the counters here
            int upperCaseCounter = 0;
            int lowerCaseCounter = 0;
         

           
            foreach (char stringLetter in inString)
            {
                if (letter.ToString().ToLower() == stringLetter.ToString())
                {
                    // matches the lowercase version
                    lowerCaseCounter++;
                }
                else if (letter.ToString().ToUpper() == stringLetter.ToString())
                {
                    // matches the UPPERCASE version
                    upperCaseCounter++;
                }
            }

            // Print output to console
            Console.WriteLine("Input: " + inString);
            Console.WriteLine("Number of lowercase " + letter + "'s found: " + lowerCaseCounter);
            Console.WriteLine("Number of UPPERCASE " + letter + "'s found: " + upperCaseCounter);
            Console.WriteLine("Total Number of " + letter + "'s found: " + (lowerCaseCounter + upperCaseCounter));
        }
    }
}
