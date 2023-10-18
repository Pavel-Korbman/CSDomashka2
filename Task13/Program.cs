// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число");
int number = Convert.ToInt32 (Console.ReadLine());
number = Math.Abs(number);
int digitNumber = 1;
int number1 = number;
int count = 0;
if (number < 100)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
     while (number1 >= 10)
     {
        number1 = number1 / 10;
        digitNumber = digitNumber * 10;
     }
       

while (count < 2)
{
number = number - (number / digitNumber * digitNumber);
digitNumber = digitNumber / 10;
count = count + 1;
}
int result = number / digitNumber;
Console.WriteLine(result);
}