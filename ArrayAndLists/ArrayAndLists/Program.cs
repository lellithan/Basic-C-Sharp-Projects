using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        //int[] numArray = new int[5];
        //numArray[0] = 5;
        //numArray[1] = 2;
        //numArray[2] = 10;
        //numArray[3] = 200;
        //numArray[4] = 5000;

        //int[] numArray1 = new int[] { 5, 2, 1, 200, 5000 };

        //int[] numArray2 = { 5, 2, 1, 200, 5000, 600, 2300 };

        //numArray2[5] = 650;

        //Console.WriteLine(numArray2[5]);

        //Console.WriteLine(numArray[3]);

        List<string> intList = new List<string>();
        intList.Add("Ellie");
        intList.Add("Kelsey");
        intList.Remove("Kelsey");

        Console.WriteLine(intList[0]);
        Console.ReadLine();
    }
}
