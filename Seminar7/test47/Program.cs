// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


int m = 3;
int n = 4;

double[,] array = GenerateRandomArray(m, n);

PrintArray(array);

static double[,] GenerateRandomArray(int m, int n)
{
double[,] array = new double[m, n];
Random random = new Random();

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = random.NextDouble() * 20 - 10; // Генерация случайного числа от -10 до 10
    }
}

return array;
}

static void PrintArray(double[,] array)
{
int m = array.GetLength(0);
int n = array.GetLength(1);

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write("\t" + array[i, j].ToString("F1"));
    }
    Console.WriteLine();
}
}