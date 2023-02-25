using System;
using System.Collections.Generic;
using System.IO;

namespace ExceptionHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // --------------------------------------------------------------------------------------
            // First create an char[], it must contain 6 numbers and 3 letters - name it arr
            // Create a list called numbers that will hold integers
            // Create an string variable with an empty string initializer - name it str

            var arr = new char[] { '1','Q','2','A','3','4','G','5','6' };
            var numbers = new List<int>();
            string str="";

            // using a foreach loop, attempt to parse the elements in your char[] with int.Parse()
            // and Exceptions will be thrown 
            // Below we will set this up 
            // --------------------------------------------------------------------------------------
            
            // Make a foreach loop to iterate through your character array
            foreach (char c in arr)
            {
                // Now create a try catch                
                try
                {
                    // set your string variable to each array element in your char[] to .ToString()
                    // Now, using int.Parse, parse your string variable and store in an int variable
                    // Then add each int to your list
                    str = c.ToString();
                    int i = int.Parse(str);
                    numbers.Add(i);
                }
                // catch your Exception:
                catch (Exception e)
                {
                    Console.WriteLine($"Unable to Parse '{c}'");        //character will be the name of each item in your collection
                }

            }

            //Could do this in a FINALLY block, but not necessary since execution drops down here anyway.
            Console.WriteLine("Resulting list of converted numbers...");
            foreach (var num in numbers)
                Console.WriteLine(num);
        }
    }
}
