// Программа выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.


// int Number = new Random().Next(1, 1500);
// System.Console.WriteLine();
// System.Console.WriteLine($"Дано число: {Number}");

Console.WriteLine("Введите число: ");
int Number = int.Parse(Console.ReadLine()!);
if (Number / 100 > 0) 
{
    Console.WriteLine($"Число {Number / 100 % 10} является третьей цифрой числа {Number}.");
}

else 
{
    Console.WriteLine($"У числа {Number} нет третьей цифры!");
}