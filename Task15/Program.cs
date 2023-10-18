// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

 void week(int number)
{
if (number == 6 || number == 7)
  {
    Console.WriteLine("да");
  }
  else
  {
    Console.WriteLine("нет");
  } 
}
Console.WriteLine("Введите число, обозначающее день недели");
int number = Convert.ToInt32 (Console.ReadLine());

if (number < 1 || number > 7)
{
    Console.WriteLine("День недели должен быть от 1 до 7");
}
else
{
week(number);
}