// Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

int m = ReadInt("Задайте количество строк: ");
int n = ReadInt("Задайте количество столбцов: ");
int[,] matrix = new int[m, n];

FillArray(matrix);
PrintArray(matrix);
Order(matrix);
Console.WriteLine();
PrintArray(matrix);

void Order(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1) - 1; j++)
        {
            int minPos = j;

            for (int p = j + 1; p < matr.GetLength(1); p++)
            {
                if (matr[i, p] < matr[i, minPos])
                {
                    minPos = p;
                }
            }
            int temp = matr[i, j];
            matr[i, j] = matr[i, minPos];
            matr[i, minPos] = temp;
        }
    }
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}