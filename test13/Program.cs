// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число не менее трёхзначного (от 100 до 999)");

string? a = Console.ReadLine();

int aa = Convert.ToInt32(a);            //Перводим значение строки в число
// if (99999 > aa > 99)
// {
//         Console.WriteLine($"У {aa} -> третьей цифры нет!");
// }

int Digit1 = aa % 10;                   //Последнее число (слева наравво) из 3-х значного
int Digit2 = aa /10 % 10;               //Предпоследнее число из 3-х значного
int Digit3 = aa / 100 % 10;             //Предпредпоследнее число из 3-х значного
int Digit4 = aa / 1000 % 10;  
int Digit5 = aa / 10000 % 10;  

string numberString1 = Digit1.ToString();
string numberString2 = Digit2.ToString();
string numberString3 = Digit3.ToString();
string numberString4 = Digit4.ToString();
string numberString5 = Digit5.ToString();

if (numberString5 = 0)
{
  String SumString = numberString1 + numberString2 + numberString3 + numberString4; //Это не изучали.
  
        int bb = Convert.ToInt32(SumString);            //Перводим значение строки в число

        int Digit03 = bb / 100% 10; 
        Console.WriteLine(bb);
        Console.WriteLine($"{aa} -> {Digit03}");
}
else
{
        String SumString = numberString1 + numberString2 + numberString3 + numberString4  + numberString5; //Это не изучали.
  
}