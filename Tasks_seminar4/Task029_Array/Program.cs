// Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
// 5 -> [1, 2, 5, 7, 19]
// 3 -> [6, 1, 33]

Console.Write("Введите число: ");  // вводим длину
int n = Convert.ToInt32(Console.ReadLine());

int[] numbers = new int[n];


void FillArray(int[] array)
{
   for(int i = 0; i < n; i++)
   {
     array[i] = new Random().Next(0, 100);
   }
}
 void PrintArray(int[] array)
{
    for(int i = 0; i < n; i++)
   {
     Console.Write(array[i] + " ");
   }
}


FillArray(numbers);
PrintArray(numbers);
