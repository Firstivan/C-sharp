//Задача 2: Напишите программу, которая на вход принимает два числа
// и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число");
string? a = Console.ReadLine();
Console.WriteLine("Введите второе число");
string? b = Console.ReadLine();
int aa = Convert.ToInt32(a);
int bb = Convert.ToInt32(b);
if (aa > bb)
{
   Console.Write("Наибольшее число: ");
   Console.WriteLine(a); 
}
else
{
   Console.Write("Наибольшее число: ");
   Console.WriteLine(b);

}