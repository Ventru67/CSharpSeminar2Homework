// Найти расстояние между точками в пространстве 2D/3D
Console.Write("X: ");
int x1 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Y: ");
int y1 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Z: ");
int z1 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("X: ");
int x2 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Y: ");
int y2 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Z: ");
int z2 = int.Parse(Console.ReadLine() ?? "0");


double distance = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));

Console.WriteLine(distance);
