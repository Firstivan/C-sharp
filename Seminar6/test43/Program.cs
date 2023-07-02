// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

 Console.WriteLine("Введите значения b1, k1, b2 и k2 для уравнений y = k1 * x + b1 и y = k2 * x + b2:");
        double b1 = ReadDouble("b1:");
        double k1 = ReadDouble("k1:");
        double b2 = ReadDouble("b2:");
        double k2 = ReadDouble("k2:");

        double intersectionX, intersectionY;
        if (TryFindIntersection(b1, k1, b2, k2, out intersectionX, out intersectionY))
        {
            Console.WriteLine("Точка пересечения: ({0}; {1})", intersectionX, intersectionY);
        }
        else
        {
            Console.WriteLine("Прямые не пересекаются.");
        }

    static bool TryFindIntersection(double b1, double k1, double b2, double k2, out double x, out double y)
    {
        if (Math.Abs(k1 - k2) < double.Epsilon)
        {
            x = 0;
            y = 0;
            return false;
        }

        x = (b2 - b1) / (k1 - k2);
        y = k1 * x + b1;
        return true;
    }

    static double ReadDouble(string message)
    {
        Console.Write(message);
        double result;
        while (!double.TryParse(Console.ReadLine(), out result))
        {
            Console.WriteLine("Некорректный ввод. Попробуйте еще раз.");
            Console.Write(message);
        }
        return result;
    }