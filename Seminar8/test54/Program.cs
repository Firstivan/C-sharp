// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы
// каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// const int Rows = 3;
// const int Columns = 4;
// int[,] GetRandomMatrix(int row, int columns)
// {
// int[,] matrix = new int[row, columns];   
// for(int i = 0; i < matrix.GetLength(0); i++)   //i stroli     j stolbtsy
// {
//     for(int j = 0; j < matrix.GetLength(1); j++)    //гет лент - чисто строка
//     {
//         matrix[i, j] = Random.Shared.Next(1, 10);
//     }
// }
// return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
// for(int i = 0; i < matrix.GetLength(0); i++)
// {
//     for(int j = 0; j < matrix.GetLength(1); j++)
//     {
//         Console.Write($"{matrix[i, j]} ");
//     }
//     Console.WriteLine();
// }
// }

// void SwapFirstAndLastRows(int[,] array)
// {
//     int rowCount = array.GetLength(0);
//     int columnCount = array.GetLength(1);
//     for(int j = 0; j < columnCount; j++)
//     {
//         int temp = array[0, j];
//             array[0, j] = array[rowCount - 1, j];
//             array[rowCount - 1, j] = temp;
//     }
// }

// int[,] myMatrix = GetRandomMatrix(Rows, Columns);
// PrintMatrix(myMatrix);
// SwapFirstAndLastRows(myMatrix);
// Console.WriteLine();
// PrintMatrix(myMatrix);