// Программа принимает на вход трёхзначное число и на выходе 
// показывает вторую цифру этого числа.

Console.WriteLine("Введите трёхзначное число: ");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Второй цифрой числа {number} является {number / 10 % 10} ");