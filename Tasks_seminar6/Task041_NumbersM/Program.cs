// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Укажите количество чисел: ");
int[] numbers = new int[Convert.ToInt32(Console.ReadLine())];
Console.Write("Введите числа: ");
int count = 0;

void FillArrayNumbres(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

// void PrintArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

FillArrayNumbres(numbers);
//PrintArray(numbers);

Console.WriteLine(string.Join(", ", numbers));

int Num(int[] num, int col)
{
    for (int i = 0; i < col; i++)
    {
       if(num[i] > 0)
       {
        count++;
       }       
    }
    return count;
}
int result = Num(numbers, numbers.Length);
Console.Write(result);