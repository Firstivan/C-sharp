// Задача №26. 
// Подсчитать количество цифр в веденном числе.

int ReadInt()
{
Console.WriteLine("Введите целое число!");
int value = Convert.ToInt32(Console.ReadLine());
return value;   // потому что не void
}
int func(int number)
{
    int colvo = 1;
    while (number >= 10)
    {
        number = number / 10; // Или sum++
        colvo++;
    }
    return colvo; // потому что не void
}
int number = ReadInt();
int colvo1 = func(number);
Console.WriteLine($"Количество цифр в числе = {colvo1}");