// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] array = new int[4];       // Создаем массив из 4 элементов

        Random random = new Random();

for (int i = 0; i < array.Length; i++)      // Заполняем массив случайными положительными трехзначными числами
{
    array[i] = random.Next(100, 1000);
}

Console.WriteLine("Массив:");               // Выводим значения массива на экран
foreach (int element in array)
{
    Console.WriteLine(element);
}

int evenCount = 0;                  // Подсчитываем количество четных чисел в массиве
foreach (int element in array)
{
    if (element % 2 == 0)
    {
        evenCount++;
    }
}

Console.WriteLine("Количество четных чисел: " + evenCount);
