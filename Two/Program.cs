﻿Console.WriteLine("введите три числа");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
int max = a;
if (b > max)
{
    max = b;
}
else if (c > max)
{
    max = c;
}
Console.WriteLine("наибольшее число: " + max);


