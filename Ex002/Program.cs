// По двум заданным числам проверять является ли одно квадратом другого
Console.Write("Введите число A: ");
int firstNumber = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите число B: ");
int secondNumber = int.Parse(Console.ReadLine() ?? "0");


if (secondNumber == (firstNumber * firstNumber))
{
        System.Console.WriteLine("Число B это квадрат числа A");
}
else if (firstNumber == (secondNumber * secondNumber)) 
{
        System.Console.WriteLine("Число A это квадрат числа B");
}
else 
{
    System.Console.WriteLine("Числа не являются квадратми друг-друга");
}