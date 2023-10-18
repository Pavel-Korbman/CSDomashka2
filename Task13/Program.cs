// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int digitNumber(int number)
{
int res = 1;  
while (number >= 10)
     {
        number = number / 10;
        res = res * 10;
     }
return res;
}


int thirdNumber(int num)
{
int count = 0;  
while (count < 2)
  {
  num = num % digitNumber(num);
  count = count + 1;
  }
return num;
}


Console.WriteLine("Введите число");
int number = Convert.ToInt32 (Console.ReadLine());
number = Math.Abs(number);
if (number < 100)
{
    Console.WriteLine("третьей цифры нет");
}
else
{      
int digit = thirdNumber(number) / digitNumber(thirdNumber(number));
Console.WriteLine(digit);
}