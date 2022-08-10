// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


int number = ReadInt("Введите трёхзначное число: ");
int firstDigit = number / 100;
int secondDigit = number / 10;

int secondNumber = secondDigit - firstDigit * 10; 
Console.WriteLine(secondNumber);

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
