// Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
 Console.Write("Введите первую точку координаты А: ");
    int x1 = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите вторую точку координаты А: ");
    int y1 = int.Parse(Console.ReadLine() ?? "");
    Console.Write("Введите третью точку координаты А: ");
    int z1 = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите первую точку координаты В: ");
    int x2 = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите вторую точку координаты В: ");
    int y2 = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите третью точку координаты В: ");
    int z2 = int.Parse(Console.ReadLine() ?? "");

int deltaX = x2 - x1;
int deltaY = y2 - y1;
int deltaZ = z2 - z1;

double result = Math.Sqrt((deltaX*deltaX)+(deltaY*deltaY)+(deltaZ*deltaZ));
Console.WriteLine($"Координаты точек А ({x1},{y1},{z1}), B ({x2},{y2},{z2}) и получаем расстояние {result:f2}");
