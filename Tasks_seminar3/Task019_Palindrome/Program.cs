// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int number = ReadInt("Введите пятизначное число: ");
int numberA = number / 10000;
int numberB = number / 1000 - numberA * 10;
int numberC = number / 10 % 10;
int numberD = number % 10;

if (numberA == numberD && numberB == numberC)
{
    Console.WriteLine("Палиндром");
}
else
{
    Console.WriteLine("Не является палиндромом");
}

int ReadInt(string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}