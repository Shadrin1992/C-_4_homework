﻿// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите степень числа");
int pow = Convert.ToInt32(Console.ReadLine());
int result = 1;
int i = 0;

for(i=1; i<=pow; i++)
{
    result = result*num;
}
Console.WriteLine(result);