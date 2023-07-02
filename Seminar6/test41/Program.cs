// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int count = 0; // переменная для хранения количества чисел больше 0

int PromptInt(string message)
{
    Console.WriteLine(message);
    int result;
    while (int.TryParse(Console.ReadLine(), out result) == false)
    {
        Console.WriteLine("Некорректный ввод. Попробуйте еще раз.");
    }
    return result;
}

int M = PromptInt("Введите количество чисел:");
int[] numbers = new int[M];

for (int i = 0; i < M; i++)
{
    numbers[i] = PromptInt($"Введите число {i + 1}:");
    
    if (numbers[i] > 0)
    {
        count++;
    }
}

Console.WriteLine("Количество чисел больше 0: " + count);