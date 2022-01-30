using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    public class HarmonicNumber
    {
        public void GetHarmonic()
        {
            float h1 = 1;
            Console.WriteLine("Enter which harmonic number you need:");
            int number = (int)Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= number; i++)
            {
                h1 += (float)1 / i;
            }
            Console.WriteLine("Harmonic number is : {0}", h1);

        }
    }
}
