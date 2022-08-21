//  Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Write("Введите размер массива: ");
int[] numbers = new int[Convert.ToInt32(Console.ReadLine())];
int count = 0;
FillArrayRandomNumbres(numbers);
PrintArray(numbers);

int Method(int[] quan, int num, int counter)
{
 for(int i = 0; i < num; i++)
    {
         if(quan[i] % 2 == 0)
         counter ++;
    }
    return counter;
}
int result = Method(numbers, numbers.Length, count);
Console.WriteLine(result);

void FillArrayRandomNumbres(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}


