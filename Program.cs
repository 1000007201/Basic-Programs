﻿// See https://aka.ms/new-console-template for more information
using BasicProgram;
bool flag = true;


while (flag)
{
    Console.WriteLine("Enter Value:\n" +
        "1.Head and Tail percentage\n" +
        "2.Check Leap Year\n"+
        "3.Exit");
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
            flag = false;
            break;
    }

}
