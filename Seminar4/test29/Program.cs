// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int length = 8; // Длина массива равна 8

Console.WriteLine("Введите начальное значение диапазона:");
int minValue = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите конечное значение диапазона:");
int maxValue = Convert.ToInt32(Console.ReadLine());

Random random = new Random();
int[] array = new int[length];

for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(minValue, maxValue + 1);
}

Console.WriteLine("Массив:");
string arrayString = string.Join(", ", array);
Console.WriteLine(arrayString);

Console.WriteLine("Длина массива: " + array.Length);
Console.WriteLine("Первое значение: " + array[0]);
Console.WriteLine("Конечное значение: " + array[array.Length - 1]);