﻿// Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным. 6 -> да, 7 -> да, 1 -> нет

Console.Clear();
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = {1, 2, 3, 4, 5, 6, 7};
if ( num > array[4])
{
    Console.WriteLine("Выходной");
}
else
{
    Console.WriteLine("Рабочий день");
}



