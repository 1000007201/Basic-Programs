using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    public class Toss
    {
        int head_count = 0;
        int tail_count = 0;
        public void TossResult()
        {
            Random rand = new Random();
            Console.WriteLine("Enter number of times coin flipped:");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                double random_number = rand.NextDouble();
                if (random_number < 0.5)
                {
                    tail_count++;
                }
                else
                {
                    head_count++;
                }

            }
            Console.WriteLine("Percentage of Head: {0}\nPercentage of Tail: {1}", ((double)head_count / (double)number) * 100, ((double)tail_count / (double)number) * 100);

        }

    }
}
