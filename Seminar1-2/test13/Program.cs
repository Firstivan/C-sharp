// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите произвольное число");
String? a = Console.ReadLine();

int number = Convert.ToInt32(a);
int count = a.Length;

if (count < 3)
{
    Console.Write("-> третьей цифры нет");
}
   
else 
{   
int result = ((int)(number / Math.Pow(10, count-3))%10);
Console.WriteLine($"Треья цифра числа {a} -> {result}");
}