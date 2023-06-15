Console.WriteLine("Введите число");
string? a = Console.ReadLine();

int aa = Convert.ToInt32(a);

if (aa % 2 == 0)
{
   Console.Write("Число является чётным"); 
}

else
{
    Console.Write("Число нечётное!!!!");
}