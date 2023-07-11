// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] GenerateArray()
{
    int rows = 4;
    int columns = 4;
    int[,] array = new int[rows, columns];
    Random random = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = random.Next(10, 100); // Генерация произвольного двузначного числа (10-99)
        }
    }

    return array;
}

void PrintArray(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int numDigits = Math.Max(rows, columns).ToString().Length + 1;

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(array[i, j].ToString().PadLeft(numDigits, ' '));
        }
        Console.WriteLine();
    }
}

int[,] originalArray = GenerateArray();

Console.WriteLine("Исходный массив:");
PrintArray(originalArray);
Console.WriteLine();

int[,] spiralMatrix = GetSpiral();

Console.WriteLine("Спиральная матрица:");
PrintArray(spiralMatrix);