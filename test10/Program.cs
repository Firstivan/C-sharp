// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе 
//показывает вторую цифру этого числа.
// 456 -> 5

Console.WriteLine("Put a number from three numbers (from 100 to 999)");
string? a = Console.ReadLine();

int aa = Convert.ToInt32(a);

int lastDigit = aa % 10;
int secondDigit = aa /10 % 10;
int firstDigit = aa / 100;

//Console.WriteLine(firstDigit);
//Console.WriteLine(secondDigit);
//Console.WriteLine(lastDigit);

Console.WriteLine($"second number of {aa} is -> {secondDigit}");
 