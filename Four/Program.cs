﻿Console.WriteLine("введите число");
int n = int.Parse(Console.ReadLine());
for (int i = 1; i < n + 1; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}



