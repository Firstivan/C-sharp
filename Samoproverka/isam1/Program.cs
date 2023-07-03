// Самопроверка!!!!// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе 
//показывает вторую цифру этого числа.
// 456 -> 5

int Prompt(string message)
{
    Console.WriteLine(message);  // Выводим сообщение пользователю
    string value = Console.ReadLine(); // Читаем введенную пользователем строку
    int result = Convert.ToInt32(value); // Преобразуем строку в целое число
    return result; // Возвращаем полученное значение
}

int number = Prompt("ВВедите трёхзначное число >");
if (number < 100 || number >= 1000)
{
    Console.WriteLine("Введено не корректное число");
    return;
}
Console.WriteLine($"Введенное число: {number}");
int secondRank = number / 10 % 10;
Console.WriteLine($"Вторая цифра введенного числа {secondRank}");