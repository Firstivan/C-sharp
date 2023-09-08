// Задача №24.
// Написать программу которая выдаёт сумму чисел от 1 до введённого числа.

// int ReadInt()
// {
// Console.WriteLine("Введите целое число!");
// int value = Convert.ToInt32(Console.ReadLine());
// return value;   // потому что не void
// }
// int Sum1ToA(int a)
// {
//     int sum = 0;
//     for (int i=1; i <= a; i++)
//     {
//         sum = sum + i; // Или sum++
//     }
//     return sum;// потому что не void
// }
// int number = ReadInt();
// int Summa = Sum1ToA(number);
// Console.WriteLine($"Сумма чисел от 1 до введённого числа = {Summa}");
// ____________________________________________________________________

// int numberA = new Random().Next(1, 10);     // Случайные числа от 1 до 10
// int numberB = Random.Shared.Next(11, 12);    // Случайные числа от 11 до 12
// Console.WriteLine(+(numberA + numberB));
//_______________________________________________________________

int number = new Random().Next(100, 999);
int a = number / 100 % 10;
int b = number % 10;

Console.WriteLine($"a = {a}, b = {b} -> {a*10+b}");