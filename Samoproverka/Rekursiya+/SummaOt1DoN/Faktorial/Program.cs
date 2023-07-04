// Факториал числа (рекурсия)

int FactorialFor(int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *=i; // *= для умножения значения result на i,
    return result;
}

int FactorialRec(int n)
{
    if (n == 1) return 1;                   // это условие выхода из цикла
    else return n * FactorialRec(n - 1);    // условие возврата
}

Console.WriteLine(FactorialFor(5));
Console.WriteLine(FactorialRec(5));
