// Найти сумму элементов от M до N, N и M заданы

int numberN = ReadInt("Введите число N: ");
int numberM = ReadInt("Введите число M: ");

int Sum(int m, int n)
{
    if (m == n)
    {
        return n;
    }
    return m + Sum(m + 1, n);
}

if (numberM < numberN)
{
    Console.WriteLine(Sum(numberM, numberN));
}
if (numberN < numberM)
{
    Console.WriteLine(Sum(numberN, numberM));
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}