﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа. 456 -> 5, 782 -> 8, 918 -> 1

Console.Clear();

int number = StringToInt("Введите трехзначное число: ");
int num = number.ToString().Length;

if (num < 3 || num > 3)
{
    Console.WriteLine("Вы ввели не трехзначное число");
}
else
{
    Console.WriteLine(SecondNum(number));
}

// Функция принимает сообщение для отображения в консоли, и выводит результат введенных данных пользователем. 
int StringToInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

// Функция вывода цифры стоящей в середине трехзначногно числа.
int SecondNum(int a)
{
    
    int result = ((a / 10) % 10);
    return result;
}





