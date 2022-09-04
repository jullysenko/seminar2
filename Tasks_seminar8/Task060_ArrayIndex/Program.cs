// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)
int[] rndArray = GetRandom(90);
int[,,] matrix = new int[2, 2, 2];

FillArray(matrix, rndArray);
PrintArray(matrix);
Console.WriteLine();

void PrintArray(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int p = 0; p < matr.GetLength(2); p++)
            {
                Console.Write($"{matr[i, j, p]}\t");
                Console.Write($"({i},{j},{p})\t");
            }
            Console.WriteLine();
        }
    }
}

int[] GetRandom(int length)
{
    Random rnd = new Random();
    int[] number = new int[length];
    for (int i = 0; i < number.Length; i++)
    {
        int a = rnd.Next(10, 100);
        if (number.Contains(a))
        {
            i--;
        }
        else
            number[i] = a;
    }
    return number;
}

void FillArray(int[,,] matr, int[] number)
{
    int k = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int p = 0; p < matr.GetLength(2); p++)
            {
                matr[i, j, p] = number[k];
                k++;
            }
        }
    }

}