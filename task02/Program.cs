﻿
/*/
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6

/*/

Console.WriteLine("Введите число");

string str=Console.ReadLine();
int A = int.Parse(str);

if (A < 100) Console.WriteLine("третьей цифры нет");

else
{
    while (A > 999)
    {
        A = A / 10;
    }
    Console.WriteLine(A % 10);

    //Console.WriteLine(str[2]);
}