// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число А: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число В: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int degree = 1;

int Degree (int A, int B)
{
for (int count = 1; count <= B; count++)
{
    degree *= A;
}
return degree;
}
int result = Degree(numberA, numberB);
Console.WriteLine(result);