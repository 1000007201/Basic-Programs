using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    public class GreatestOfThree
    {
        public void Greatest()
        {
            Console.Write("Enter First Number:");
            int first_number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Number:");
            int second_number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Third Number:");
            int third_number = Convert.ToInt32(Console.ReadLine());
            if (first_number > second_number && first_number > third_number)
                Console.WriteLine("{0} number is greatest", first_number);
            if (second_number > third_number && second_number > first_number)
                Console.WriteLine("{0} number is greatest", second_number);
            if (third_number > first_number && third_number > second_number)
                Console.WriteLine("{0} number is greatest", third_number);
            else
                Console.WriteLine("Please,give appropriate input!!");
        }

    }
}
