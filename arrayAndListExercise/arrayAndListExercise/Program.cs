using System;
using System.Collections.Generic;




class Program
{
    static void Main()
    {
        string[] colorArray = { "", "Red", "Blue", "Green", "Purple", "Pink", "Orange" };
        Console.WriteLine("Please pick number between 1-6");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Your color is: " + colorArray[num1]);
        Console.ReadLine();

        int[] numArray = { 0, 15, 56, 24, 36, 85, 75, 26, 51 };
        Console.WriteLine("Please pick number between 1-8");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Your number is: " + numArray[num2]);
        Console.ReadLine();

        List<string> carList = new List<string>();
        carList.Add("Ford");
        carList.Add("Chevy");
        carList.Add("Honda");
        carList.Add("Nissan");
        carList.Add("Toyota");
        carList.Add("Hyundai");
        Console.WriteLine("Pick a number between 0-6.");
        int num3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The car make you picked is: "+carList[num3]);
        Console.ReadLine();




    }
}

