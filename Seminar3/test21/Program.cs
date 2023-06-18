// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и
// находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите значение по оси Х первой точки");
string? x1 = Console.ReadLine();

Console.WriteLine("Введите значение по оси У первой точки");
string? y1 = Console.ReadLine();

Console.WriteLine("Введите значение по оси Z первой точки");
string? z1 = Console.ReadLine();

Console.WriteLine("Введите значение по оси Х второй точки");
string? x2 = Console.ReadLine();

Console.WriteLine("Введите значение по оси У второй точки");
string? y2 = Console.ReadLine();

Console.WriteLine("Введите значение по оси Z второй точки");
string? z2 = Console.ReadLine();

int AX = Convert.ToInt32(x1);
int AY = Convert.ToInt32(y1);
int AZ = Convert.ToInt32(z1);

int BX = Convert.ToInt32(x2);
int BY = Convert.ToInt32(y2);
int BZ = Convert.ToInt32(z2);

double lengthAB = Math.Sqrt(Math.Pow(AX-BX, 2)+Math.Pow(AY-BY, 2)+Math.Pow(AZ-BZ, 2));

Console.WriteLine($"Длина отрезка определённого точками составляет {lengthAB} едениц.");