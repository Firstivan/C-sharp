// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4


Console.WriteLine("Введите число");
string? a = Console.ReadLine();

int aa = Convert.ToInt32(a);


for (int i=2; i<=aa; i=i+2)
{
   Console.Write(i); 
}