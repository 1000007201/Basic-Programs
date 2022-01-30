using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    public class Division
    {
        public void Divide()
        {
            Console.Write("Enter Divident:");
            int divident = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Divisor:");
            int divisor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Quotient:{0}", divident / divisor);
            Console.WriteLine("Remainder:{0}", divident % divisor);
        }
    }
}
