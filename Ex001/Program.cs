// Дано число обозначающее день недели. Выяснить является номер дня недели выходным
Console.Write("Введите номер дня недели(1-7): ");
int number = int.Parse(Console.ReadLine() ?? "0");

if (number <= 5)
{
    Console.WriteLine("Будний день");
}
else 
{
    Console.WriteLine("Выходной день");
}