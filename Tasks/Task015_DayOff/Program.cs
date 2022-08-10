// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число:");
string input = Console.ReadLine();
int numberA = Convert.ToInt32(input);

if (numberA == 1 || numberA == 2 || numberA == 3 || numberA == 4 || numberA == 5) 
{
    Console.WriteLine("Не выходной");
}

if (numberA == 6 || numberA == 7)
{
    Console.WriteLine("Выходной!");
}
