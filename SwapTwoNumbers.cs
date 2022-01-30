using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    public class SwapTwoNumbers
    {
        public void Swap()
        {
            Console.Write("Enter First Number:");
            int first_number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Number:");
            int second_number = Convert.ToInt32(Console.ReadLine());
            /*
             * a = a+b
             * b = a-b
             * a = a-b*/
            first_number = first_number + second_number;
            second_number = first_number - second_number;
            first_number = first_number - second_number;
            Console.WriteLine("First Number:{0}\nSecond Number:{1}",first_number,second_number);
        }
    }
}
