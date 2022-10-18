// Программа принимает на вход целое число любой разрядности 
// и удаляет вторую цифру этого числа.

Console.WriteLine("Введите любое целое число любой разрядности: ");
int Number = int.Parse(Console.ReadLine()!);
int NewNumber = 0;

    int NumberWithoutSecDig()

    {
        NewNumber = Number / 100 * 10 + Number % 10;
        return NewNumber;
    }

NumberWithoutSecDig();
Console.WriteLine($"Если из данного числа удалить вторую цифру, получится число {NewNumber}.");