// Напишите программу, которая выводит случайное число из 
// отрезка [10, 99] и показывает наибольшую цифру числа.
// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8

Random rand = new Random();
int number = new Random().Next(10,100);
System.Console.WriteLine($"случайное число: {number}");

int leftNumber = number/10;
int rightNumber = number%10;

// System.Console.WriteLine($"{leftNumber}{righNumber}");

if (leftNumber>rightNumber)
{
    System.Console.WriteLine($"Левое число больше и равно {leftNumber}");
}

else if (leftNumber<rightNumber)
{
    System.Console.WriteLine($"Правое число больше и равно {rightNumber}");
}
else {System.Console.WriteLine("Числа равные");
}