// See https://aka.ms/new-console-template for more information
using BasicProgram;
bool flag = true;


while (flag)
{
    Console.WriteLine("Enter Value:\n" +
        "1.Head and Tail percentage\n" +
        "2.Check Leap Year\n" +
        "3.Power of Two\n" +
        "4.Harmonic Number\n"+
        "5.Swap Two Numbers\n"+
        "6.Exit");
    int value = Convert.ToInt32(Console.ReadLine());
    switch (value)
    {
        case 1:
            Toss toss = new Toss();
            toss.TossResult();
            break;
        case 2:
            LeeapYear leapyear = new LeeapYear();
            leapyear.YearCheck();
            break;
        case 3:
            PowerOfTwo powerOfTwo = new PowerOfTwo();
            powerOfTwo.Power();
            break;
        case 4:
            HarmonicNumber harmonic = new HarmonicNumber();
            harmonic.GetHarmonic();
            break;
        case 5:
            SwapTwoNumbers swap = new SwapTwoNumbers();
            swap.Swap();
            break;
        case 6:
            flag = false;
            break;
    }

}
