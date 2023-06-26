// Задача №24.1
// Написать программу которая выдаёт сумму чисел от 1 до введённого числа.

int ReadInt(string message)
{
Console.WriteLine(message);
return Convert.ToInt32(Console.ReadLine()); // потому что не void

}
int Sum1ToA(int a)
{
    int sum = 0;
    for (int i=1; i <= a; i++)
    {
        sum = sum + i; // Или sum++
    }
    return sum;// потому что не void
}
int number = ReadInt("введите целое число!");
int Summa = Sum1ToA(number);
Console.WriteLine($"Сумма чисел от 1 до введённого числа = {Summa}");