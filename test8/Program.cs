Console.WriteLine("Введите число");
string? a = Console.ReadLine();

int aa = Convert.ToInt32(a);

for (int i=2; i<=aa; i=i+2)
{
   Console.Write(i); 
}