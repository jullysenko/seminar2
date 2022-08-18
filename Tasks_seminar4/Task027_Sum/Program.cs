//                                                Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12



Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;

// while (number > 0)
// {
//    int num = number % 10;
//    number = number / 10;
//     sum = sum + num;
//  }

// Console.WriteLine(sum);


int Sum(int count)
{
    while (count > 0)
{
   int num = count % 10;
   count = count / 10;
    sum = sum + num;
 }
return sum;
}
int result = Sum(number);
Console.WriteLine(result);

