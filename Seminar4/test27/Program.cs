// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Prompt (string message)
{
    System.Console.WriteLine(message);
    string readInput = System.Console.ReadLine();
    int result = int.Parse(readInput);              // приводим к числу
    return result;
}

int SumAllDigit(int number)
{
    int result = 0;
    while (number != 0)
    {
        result += number%10;        // Получаем последнюю цифру числа и Добавляем цифру к сумме
        number = number /10;        // Удаляем последнюю цифру числа
    }
    return result;
}

int number = Prompt("Введите произвольное целое число:");
System.Console.WriteLine($"Сумма всех чисел в цифре {number} равно {SumAllDigit (number)}");
