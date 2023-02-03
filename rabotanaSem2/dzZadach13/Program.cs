// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


System.Console.Write("Введите число: ");
int num = Convert.ToInt32(System.Console.ReadLine());

if (Math.Abs(num) > 99)
{
    while (Math.Abs(num) > 1000) num = num / 10;
    System.Console.WriteLine("Третья цифра - это: " + (num % 10));
}
else System.Console.WriteLine("Третьей цифры нет");