// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double b1 = ReadInt("Введите b1: ");
double k1 = ReadInt("Введите k1: ");
double b2 = ReadInt("Введите b2: ");
double k2 = ReadInt("Введите k2: ");

double x = 1;  
double y = 1;    

if (k1 != k2)
{   x = x * (b2 - b1) / (k1 - k2);
    y = y *(k1 * x + b1);
    Console.Write($"Точка пересечения двух прямых ({x}, {y})");
}    

else Console.Write("Прямые параллельны");

int ReadInt(string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}
