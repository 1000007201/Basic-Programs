using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    public class VowelConsonant
    {
        public void Check()
        {
            Console.Write("Enter any character:");
            char character = Convert.ToChar(Console.ReadLine().ToLower());
            if (character == 'a' || character == 'e' || character == 'i' || character == 'o' || character == 'u')
                Console.WriteLine("Entered charcter is a Vowel");
            else
                Console.WriteLine("Entered character is a Consonant");
        }
    }
}
