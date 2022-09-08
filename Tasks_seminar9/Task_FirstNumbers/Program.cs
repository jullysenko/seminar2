// Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. Первые два элемента последовательности задаются пользователем

int element1 = ReadInt("Введите первый элемент: ");
int element2 = ReadInt("Введите второй элемент: ");
int n = ReadInt("введите количество элементов N: ");

int[] fibonachi = new int[n];

fibonachi[0] = element1;
fibonachi[1] = element2;

for(int i = 2; i < n; i++)
{
    fibonachi[i] = fibonachi[i - 1] + fibonachi[i - 2];
}
// Array(fibonachi);
Console.Write(string.Join(" ", fibonachi));

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

// void Array(int[] arr, int i)
// {
//     i = 2;
//     if (i < arr.Length)
//     {
//         arr[i] = arr[i - 1] + arr[i - 2];
//         Array(arr, ++i);
//     }
//     else return;
// }
