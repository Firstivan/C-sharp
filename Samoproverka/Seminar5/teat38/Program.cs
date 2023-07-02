// Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

Console.WriteLine("Введите длину массива:");
int length = Convert.ToInt32(Console.ReadLine()); // Ввод длины массива

double[] array = new double[length];        // Создаем массив заданной длины

Random random = new Random();

for (int i = 0; i < array.Length; i++)      // Заполняем массив случайными числами
{
    array[i] = random.NextDouble() * 100;   // Генерируем случайное вещественное число от 0 до 100
}

string arrayString = "[" + string.Join(", ", array) + "]";  // Выводим массив на экран
Console.WriteLine("Массив: " + arrayString);

double min = array[0];  // Находим минимальный и максимальный элементы массива
double max = array[0];
for (int i = 1; i < array.Length; i++)
{
    if (array[i] < min)
        min = array[i];
    if (array[i] > max)
        max = array[i];
}

double difference = max - min;  // Вычисляем разницу между максимальным и минимальным элементами

Console.WriteLine("Разница между максимальным и минимальным элементами: " + difference);    // Выводим разницу на экран