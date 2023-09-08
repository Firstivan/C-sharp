// Задача 67: Напишите программу, которая выдает сумм цифр от введённого числа

int number = 115;

int SummaTsifr(int Chislo)
{
    if (Chislo <= 0) return 0; //вызывается рекурсивно до тех пор, пока значение n не станет меньше или равно 0
    return SummaTsifr(Chislo / 10) + (Chislo % 10);;
}
Console.Write(SummaTsifr(number));