using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    public class LeeapYear
    {
        public void YearCheck()
        {
            Console.WriteLine("Enter Year to be checked:");
            int year = (int)Convert.ToInt32(Console.ReadLine());
            if (Convert.ToString(year).Length == 4)
            {
                if (year % 4 == 0)
                {
                    Console.WriteLine("{0} Year is a Leap Year", year);
                }
                else
                {
                    Console.WriteLine("{0} Year is not Leap Year", year);
                }
            }
            else
            {
                Console.WriteLine("Please Enter valid Year");
            }
        }



    }
}
