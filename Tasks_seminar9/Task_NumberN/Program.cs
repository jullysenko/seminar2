// Показать натуральные числа от N до 1, N задано

Console.Write("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = 1;

string NumAB(int numA, int numB)
{
    if (numA <= numB)
    {
        return NumAB(numA + 1, numB) + $"{numA}\t";
    }
    else
    {
        return String.Empty;
    }
}
Console.WriteLine(NumAB(numberB, numberA));

