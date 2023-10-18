// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Console.WriteLine("Введите трёхзначное число");
int number = Convert.ToInt32 (Console.ReadLine());
number = Math.Abs(number);
if (number < 100 || number > 999)
{
    Console.WriteLine("Это не трёхзначное число");
}
else
{
       int result =  (number % 100) / 10;
       Console.WriteLine(result);
}