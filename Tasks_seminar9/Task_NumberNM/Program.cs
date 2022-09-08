// Показать натуральные числа от M до N, N и M заданы

int numberN = ReadInt("Введите число N: ");
int numberM = ReadInt("Введите число M: ");

string NumAB(int m, int n)
{
    if (m <= n)
    {
        return $"{m}\t" + NumAB(m + 1, n);
    }
    return String.Empty;
}

if (numberM < numberN)
{
    Console.WriteLine(NumAB(numberM, numberN));
}
if (numberN < numberM)
{
    Console.WriteLine(Num(numberN, numberM));
}

string Num(int n, int m)
{
    if (n <= m)
    {
        return $"{m}\t" + Num(n, m - 1);
    }
    return String.Empty;
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}