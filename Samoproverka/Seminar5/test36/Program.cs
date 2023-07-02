// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Введите длину массива:");
int length = Convert.ToInt32(Console.ReadLine());   // Ввод длины массива

int[] array = new int[length];  // Создаем одномерный массив заданной длины

Random random = new Random();

for (int i = 0; i < array.Length; i++)  // Заполняем массив случайными числами
{
    array[i] = random.Next(-100, 101);  // Генерируем случайное число от -100 до 100
}

string arrayString = "[" + string.Join(", ", array) + "]";  // Выводим значения массива на экран
Console.WriteLine("Массив: " + arrayString);

int sum = 0;           // Находим сумму элементов, стоящих на нечетных позициях
for (int i = 1; i < array.Length; i += 2)
{
    sum += array[i];
}

Console.WriteLine("Сумма элементов на нечетных позициях: " + sum);  // Выводим сумму на экран