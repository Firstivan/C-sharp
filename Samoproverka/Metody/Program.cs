﻿//Разные методы.

// void Method1()
// {
// Console.WriteLine("Метод 1 !");
// }

// Method1(); //Вызывыем Метод 1
//______________________________________


// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// Method2(msg: " Вызвали Метод 2."); //Вызывыем Метод 2
//______________________________________


// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// Method21("Вызвали Метод21 4 раза)))  ", 4); //Вызывыем Метод 21
//______________________________________


// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int a = Method3();
// Console.WriteLine(a);   //Вызывыем Метод 3
//______________________________________


// string Method4(int count, string input)
// {
//     int i = 0;
//     string result = string.Empty;
//     while (i < count)
//     {
//         result = result + input;
//         i++;
//     }
//     return result; 
// }
// string res = Method4(5, "Текст из Метода 4.  ");
// Console.WriteLine(res); //Вызывыем Метод 4
//______________________________________


// string Method5(int count, string input)
// {
//    string result = string.Empty;
//    for (int i = 0; i < count; i++)
//    {
//         result = result + input;
//    }
//    return result; 
// }

// string res = Method5(5, "Текст из Метода 5.  ");
// Console.WriteLine(res); //Вызывыем Метод 5
//______________________________________
//______________________________________

// проверка метода

void ReadInt (String message)
{
    Console.WriteLine(message);
    Console.ReadLine();
    return;
}

int n = (ReadInt(message: "Сообщение но не СМС"));

ReadInt(message: "Сообщение но не MMC");