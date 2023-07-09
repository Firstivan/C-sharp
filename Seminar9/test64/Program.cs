// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа
// в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int numberM = 1;
int numberN = 4;

int Perechislenie(int LastNumber, int FirstNumber)
{
    if (1 <= LastNumber) return;
    Perechislenie(FirstNumber + 1, LastNumber);
    Console.Write(FirstNumber + "");
}
Perechislenie(numberM, numberN);