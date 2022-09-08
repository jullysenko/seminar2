// Написать программу вычисления функции Аккермана

int numberM = ReadInt("Введите число M: ");
int numberN = ReadInt("Введите число N: ");

int Ackerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (n == 0 && m > 0)
    {
        return Ackerman(m - 1, 1);
    }
    else
    {
        return Ackerman(m - 1, Ackerman(m, n - 1));
    }

}
Console.WriteLine(Ackerman(numberM, numberN));

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}