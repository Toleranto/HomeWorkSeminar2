﻿internal class Program
{
    public static void Main(string[] args)
    {
        Console.Clear();
        Console.Write("Введи трёхзначное число: ");
        int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
        string stringNumber = Convert.ToString(threeDigitNumber);
        Console.WriteLine("Вторая цифра числа: " + stringNumber[1]);
    }
}