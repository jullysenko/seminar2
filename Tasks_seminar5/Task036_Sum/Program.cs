// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Write("Укажите размер массива: ");
int[] numbers = new int[Convert.ToInt32(Console.ReadLine())];
int sum = 0;
FillArrayRandomNumbres(numbers);
PrintArray(numbers);

int Sum(int[] count, int num)
{

 for(int i = 0; i < num; i++)
    {
         if(i % 2 != 0)
        {
            sum = sum + count[i];
        }
    }
    return sum;
}
int result = Sum(numbers, numbers.Length);
Console.WriteLine(result);

void FillArrayRandomNumbres(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 100);
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

