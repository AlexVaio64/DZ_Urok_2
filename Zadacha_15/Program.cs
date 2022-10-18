// Программа принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.


Console.WriteLine("Введите цифру от 1 до 7 и программа сообщит, что это за день недели и является ли он выходным: ");
int Number = int.Parse(Console.ReadLine()!);

if((0 < Number) && (Number < 8))
{
    if(Number == 1) Console.WriteLine("Это понедельник, будний день.");
    if(Number == 2) Console.WriteLine("Это вторник, будний день.");
    if(Number == 3) Console.WriteLine("Это среда, будний день.");
    if(Number == 4) Console.WriteLine("Это четверг, будний день.");
    if(Number == 5) Console.WriteLine("Это пятница, будний день.");
    if(Number == 6) Console.WriteLine("Ура! Это суббота, выходной день!");
    if(Number == 7) Console.WriteLine("Ура! Это воскресенье, выходной день!");
}
else
{
    Console.WriteLine("Вы ввели неверное число!");
}