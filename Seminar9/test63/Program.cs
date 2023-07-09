// Задача 63. Задайте значение N. Напишите программу, которая выдаёт все натуральные  числа от 1 до N.

int number = 10;

void Perechislenie(int LastNumber)
{
    if (LastNumber <= 0) return;
    Perechislenie(LastNumber - 1);
    Console.Write(LastNumber + "");
}
Perechislenie(number);