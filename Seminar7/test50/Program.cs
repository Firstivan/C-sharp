// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет
// 1, 2 -> 2

Random random = new Random();

int rowCount = 3; // Количество строк
int columnCount = 4; // Количество столбцов

int[,] array = new int[rowCount, columnCount];

    for (int i = 0; i < rowCount; i++)  // Заполнение массива случайными значениями
{
    for (int j = 0; j < columnCount; j++)
    {
        array[i, j] = random.Next(10);
    }
}

Console.WriteLine("Массив:");   // Вывод массива
for (int i = 0; i < rowCount; i++)
{
    for (int j = 0; j < columnCount; j++)
    {
        Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
}

Console.Write("Введите позицию элемента в формате 'строка, столбец': ");
string input = Console.ReadLine();
string[] positions = input.Split(',');

if (positions.Length != 2 || !int.TryParse(positions[0].Trim(), out int row) || !int.TryParse(positions[1].Trim(), out int column))
{
    Console.WriteLine("Некорректный ввод позиции.");
    return;
}

if (row >= 0 && row < rowCount && column >= 0 && column < columnCount)
{
    int element = array[row, column];
    Console.WriteLine($"Значение элемента [{row}, {column}]: {element}");
}
else
{
    Console.WriteLine("Такого элемента нет в массиве.");
}