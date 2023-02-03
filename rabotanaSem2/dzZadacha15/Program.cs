//  Задача 15: Напишите программу, которая принимает на вход цифру, 
//  обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да 
// 7 -> да 
// 1 -> нет


Console.WriteLine("введите номер дня недели");
int day = Convert.ToInt32(Console.ReadLine());

if (day > 0 && day < 8)
    if (day == 7 || day == 6)

    { Console.WriteLine("да, это выходной день"); }

    else { Console.WriteLine("нет, это рабочий день"); }

else { Console.WriteLine("такого дня недели нет"); }
