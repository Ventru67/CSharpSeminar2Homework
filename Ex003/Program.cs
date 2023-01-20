// Задать номер четверти, показать диапазоны для возможных координат
Console.Write("Задайте номер четверти(1-4): ");
int number = int.Parse(Console.ReadLine() ?? "0");

if (number == 1)
{
    Console.WriteLine("Диапазон координат [+infinity; +infinity]");
}
if (number == 2)
{
    Console.WriteLine("Диапазон координат [-infinity; +infinity]");
}
if (number == 3)
{
    Console.WriteLine("Диапазон координат [-infinity; -infinity]");
}
if (number == 4)
{
    Console.WriteLine("Диапазон координат [+infinity; -infinity]");
}