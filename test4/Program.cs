Console.WriteLine("Введите первое число");
string? a = Console.ReadLine();

Console.WriteLine("Введите второе число");
string? b = Console.ReadLine();

Console.WriteLine("Введите третье число");
string? c = Console.ReadLine();

int aa = Convert.ToInt32(a);
int bb = Convert.ToInt32(b);
int cc = Convert.ToInt32(c);
int max = 0;

if (aa > bb)
{
    max = aa; 
}

else
{
   max = bb;
}

if (cc > max)
{
    max = cc;
}

Console.Write("Наибольшее число: ");
Console.Write(max);