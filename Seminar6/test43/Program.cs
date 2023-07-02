// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите значения b1, k1, b2 и k2 для уравнений y = k1 * x + b1 и y = k2 * x + b2:");
double b1 = ReadDouble("b1:");
double k1 = ReadDouble("k1:");
double b2 = ReadDouble("b2:");
double k2 = ReadDouble("k2:");

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;

Console.WriteLine("Точка пересечения: ({0}; {1})", x, y);

static double ReadDouble(string message)
{
Console.Write(message);
double result;
while (double.TryParse(Console.ReadLine(), out result) == false)
{
    Console.WriteLine("Некорректный ввод. Попробуйте еще раз.");
    Console.Write(message);
}
return result;
}