// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

int m =  ReadInt("Задайте количество строк:\t");
int n = ReadInt("Задайте количество столбцов:\t");
int positionM = ReadInt("Укажите позицию по строкам:\t");
int positionN = ReadInt("Укажите позицию по столбцам:\t");

int element = 0;
int[,] matrix = new int[m, n];

FillArray(matrix);
PrintArray(matrix);

if (positionM >= m || positionN >= n)
{
    Console.Write($"Такого числа в массиве нет.");
}
else
{
   element = matrix[positionM, positionN];
    Console.Write($"Значение элемента: {matrix[positionM, positionN]}");
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