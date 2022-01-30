using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    public class PrimeFactorisation
    {
        public void PrimeFactor()
        {
            Console.Write("Enter number:");
            int number = Convert.ToInt32(Console.ReadLine());
            while (number % 2 == 0)
            {
                Console.Write(2 + " ");
                number /= 2;
            }

            for (int i = 3; i <= Math.Sqrt(number); i += 2)
            {
                while (number % i == 0)
                {
                    Console.Write(i + " ");
                    number /= i;
                }
            }

            if (number > 2)
                Console.Write(number);
        }
    }
}
