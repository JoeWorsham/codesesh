using System;
using System.Collections.Generic;
using System.Text;

namespace CodeSESH
{
    class StringReversal
    {
        public static void StringReverseWithCharArray() // Method created to reverse string
        {
            const string str = "Hello there stranger";

            // Convert the string to char array
            var chars = str.ToCharArray();
            // Find the length of the char array
            var length = chars.Length;

            // Print string length using string literal in console
            Console.WriteLine($"String length is: {length}");

            // Use for loop to reverse the string
            // String length = 20 and starts at 0. Use length -1 to start at char 19.
            // Index should be greater than or equal to 0 and until then continue to loop through.
            // Use i-- to decrease value through the loop from 19 to 0.
            for (var i = length - 1; i >= 0; i--)
            {
                // chars[i] will print the characters of the array with the index of length minus one to output each 
                // letter in the string will output in reverse starting at char 19 and finishing with char 0
                Console.Write(chars[i]);
            }
            
        }
    }
}
