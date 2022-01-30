// See https://aka.ms/new-console-template for more information
using BasicProgram;
bool flag = true;


while (flag)
{
    Console.WriteLine("Enter Value:\n1.Head and Tail percentage\n2.Exit");
    int value = Convert.ToInt32(Console.ReadLine());
    switch (value)
    {
        case 1:
            Toss toss = new Toss();
            toss.TossResult();
            break;
        case 2:
            flag = false;
            break;
    }

}
