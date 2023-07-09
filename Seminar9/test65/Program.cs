// Задача 65. Задайте значение M и N. Напишите программу, которая выдаёт все натуральные  числа от M до N.

int numberM = 1;
int numberN = 4;

void Perechislenie(int LastNumber, int FirstNumber)
{
    if (LastNumber <= FirstNumber -1) return;
    Perechislenie(LastNumber - 1, FirstNumber);
    Console.Write(LastNumber + "");
}
Perechislenie(numberN, numberM);