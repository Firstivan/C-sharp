// Вычислить a в степени n

int PowerFor(int a, int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= a;   // *= для умножения значения result на a,
    return result;
}

int PowerRec(int a, int n)  //Функция PowerRec реализует возведение числа a в степень n
                            // с использованием рекурсии
{
    return n == 0 ? 1 : PowerRec(a, n - 1) * a; //Если условие истинно, то возвращается значение 1,
                                                // что является базовым случаем для рекурсивной функции
                                                // возведения в степень: a^0 = 1.
                                                //Если условие ложно, то
                                                // выполняется рекурсивный вызов функции
                                                // PowerRec(a, n - 1) * a
    if (n == 0) return 1;
    else return PowerRec(a, n - 1) * a;
}

int PowerRecMath(int a, int n)
{
    if (n == 0) return 1;
    else if (n % 2 == 0) return PowerRecMath(a * a, n / 2);
    else return PowerRecMath(a, n - 1) * a;
}

Console.WriteLine(PowerFor(2, 3));
Console.WriteLine(PowerRec(2, 3));
Console.WriteLine(PowerRecMath(2, 3));