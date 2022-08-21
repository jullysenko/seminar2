// //  Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
// // [3 7 22 2 78] -> 76

Console.Write("Введите размер массива: ");
double[] numbers = new double[Convert.ToInt32(Console.ReadLine())];

FillArrayRandomNumbres(numbers);
PrintArray(numbers);

double max = numbers[0];
double min = numbers[0];

double Difference(double[] num, int collection)
{
    for (int i = 1; i < collection; i++)
    {
       if(num[i] > max)
       {
        max = num[i];
       }
       else
       {
        if(num[i] < min)
        {
            min = num[i];
        } 
       }
       
    }
    double diff = max - min;
    return diff;
}
double result = Difference(numbers, numbers.Length);
Console.WriteLine($"Максимальное число массива: {max} и минимальное число массива: {min}");

Console.WriteLine($"Разница между ними равна: {result}");

void FillArrayRandomNumbres(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(new Random().NextDouble() * 10, 1);

    }
}

void PrintArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}


