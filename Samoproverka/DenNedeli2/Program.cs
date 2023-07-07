// Console.WriteLine("Введите число:");
// string? numberString = Console.ReadLine()!;
// int numberInt = Convert.ToInt32(numberString);
// switch(numberInt)
// {
//     case 1:
//         Console.WriteLine("понедельник");
//         break;
//     case 2:
//         Console.WriteLine("вторник");
//         break;
//     case 3:
//         Console.WriteLine("среда");
//         break;
//     case 4:
//         Console.WriteLine("четверг");
//         break;
//     case 5:
//         Console.WriteLine("пятница");
//         break;
//     case 6:
//         Console.WriteLine("суббота");
//         break;
//     case 7:
//         Console.WriteLine("воскресенье");
//         break;
//     default:
//         Console.WriteLine("такого дня нет");
//         break;
// }
//__________________________________________________________________


// ﻿Console.WriteLine("Введите число N:");
// string n = Console.ReadLine();
// int m = Convert.ToInt32(n);
// for (int i = -m; i<=m; i++)
// {
//     Console.WriteLine(i);
// }
//__________________________________________________________________

// int Max(int a, int b, int c)
// {
//     int res = a;
//     if(b > res) res = b;
//     if(c > res) res = c;
//     return res;
// }

// Console.WriteLine("Введите первое число:");
// int numberInt1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число:");
// int numberInt2 = Convert.ToInt32(Console.ReadLine());;
// Console.WriteLine("Введите третье число:");
// int numberInt3 = Convert.ToInt32(Console.ReadLine());;
// Console.WriteLine($"максимальное число: {Max(numberInt1, numberInt2, numberInt3)}");
//___________________________________________

// ﻿Console.WriteLine("Введите число:");
// int numberInt = Convert.ToInt32(Console.ReadLine());
// if(numberInt % 2 == 0) Console.WriteLine("число четное");
// else Console.WriteLine("число не четное");
//_______________________________________-

﻿Console.WriteLine("Введите число:");
int m = Convert.ToInt32(Console.ReadLine());
//for (int i = 1; i<=m; i++)
for (int i = 2; i<=m; i+=2)
{
//    if(i % 2 == 0) Console.WriteLine(i);
    Console.WriteLine(i);
}