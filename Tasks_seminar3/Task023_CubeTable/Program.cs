﻿// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int number = ReadInt("Введите число: ");
int i = 1;

while(i <= number)
{
    int cube = i * i * i;
    Console.Write(cube + " ");
    i++;
}

int ReadInt(string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}