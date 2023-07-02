// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,7; 5,7; 3,7; 3.

Console.Write("Введите количество строк: ");
int rowCount = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int columnCount = int.Parse(Console.ReadLine());

Random random = new Random();   // Создаем генератор случайных чисел

int[,] array = new int[rowCount, columnCount];  // Создаем двумерный массив

for (int i = 0; i < rowCount; i++)  // Заполняем массив случайными числами
{
    for (int j = 0; j < columnCount; j++)
    {
        array[i, j] = random.Next(10); // Генерируем случайное число от 0 до 9
    }
}

Console.WriteLine("Исходный массив:");  // Вывод исходного массива
for (int i = 0; i < rowCount; i++)
{
    for (int j = 0; j < columnCount; j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}

double[] columnAverages = new double[columnCount];  // Вычисление среднего арифметического для каждого столбца
for (int j = 0; j < columnCount; j++)
{
    int sum = 0;
    for (int i = 0; i < rowCount; i++)
    {
        sum += array[i, j];
    }
    columnAverages[j] = Math.Round((double)sum / rowCount, 1);
}

Console.WriteLine("Среднее арифметическое каждого столбца:");   // Вывод среднего арифметического для каждого столбца
for (int j = 0; j < columnCount; j++)
{
    Console.WriteLine($"Столбец {j + 1}: {columnAverages[j]}");
}
