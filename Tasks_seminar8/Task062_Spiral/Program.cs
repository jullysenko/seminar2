//  Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1  2  3  4
// 12 13 14 5
// 11 16 15 6
// 10  9  8 7

int[,] matrix = new int[4, 4];

FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();

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
{int j = 0;
    int i=0;
    int number = 1;
    for (j = 0; j < matr.GetLength(1); j++)
    {
        matr[i, j] = number;
        number++;
    }    
    number = 5;
    for(i=1; i < matr.GetLength(0); i++)
     {
         j = 3;
        matr[i, j] = number;
        number++;
    }    
    number = 10;
    for( j=0; j < matr.GetLength(1)-1; j++)
     {
        i = 3;
        matr[i, j] = number;
        number--;
    }
    number = 12;
    for( i=1; i < matr.GetLength(1)-1; i++)
     {
        j = 0;
        matr[i, j] = number;
        number--;
    }
    number = 13;
    for (j = 1; j < matr.GetLength(1)-1; j++)
    {
        i = 1;
        matr[i, j] = number;
        number++;
    }    
    number = 16;
    for(j=1; j < matr.GetLength(0)-1; j++)
     {
         i = 2;
        matr[i, j] = number;
        number--;
    }
}




