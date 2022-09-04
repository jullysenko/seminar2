// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int m = ReadInt("Задайте количество строк: ");
int n = ReadInt("Задайте количество столбцов: ");
int[,] matrix = new int[m, n];

FillArray(matrix);
PrintArray(matrix);
Sum(matrix);


void Sum(int[,] matr)
{
    int sumMin = 0;
    int indexMin = 0;
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sumMin = sumMin + matrix[0, j];
        }
        
    }
    for (int i = 1; i < matr.GetLength(0); i++)
    {
        int sum = 0;

        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sum = sum + matrix[i, j];
        }
        
        if (sum < sumMin)
        {
            sumMin = sum;
            indexMin = i;
        }
    }
    Console.WriteLine();
    Console.Write($"Номер строки с наименьшей суммой элементов:\t{indexMin + 1}\t");
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