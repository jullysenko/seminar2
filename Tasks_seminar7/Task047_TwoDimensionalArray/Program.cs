//  Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Введите m");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите n");
int n = Convert.ToInt32(Console.ReadLine());

double[,] matrix = new double [m,n];

void PrintArray (double[,] matr)
{
    for (int i=0; i < matr.GetLength(0); i++)
    {
        for (int j=0; j < matr.GetLength(1); j++)
            {
            Console.Write ($"{matr[i,j]}  ");  
            }
            Console.WriteLine();
    }
}

void FillArray (double[,] matr)
    {
        for (int i=0; i < matr.GetLength(0); i++)
        {
            for (int j=0; j < matr.GetLength(1); j++)
                {
                matr[i,j] = Math.Round(new Random().NextDouble() * 10, 1);  
                }
        }
    }

FillArray(matrix);
PrintArray(matrix);

