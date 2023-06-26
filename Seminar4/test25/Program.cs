
//Задача 25: Напишите функцию, которая принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B. НЕ ИСПОЛЬЗОВАТЬ MATH.POW()

int ReadInt()                                       //Обозначаем метод для ввода числа
{
Console.WriteLine("Введите целое число!");          //Выводим на экран
int value = Convert.ToInt32(Console.ReadLine());    //Конвертирупм введённую с троку в число
return value;                                       // потому что не void (возвращаем метод)
}

int Chisla (int A, int B)          //Задали функцию которая принимает два числа
{
    int number = A;
    for(int i = 1; i < B; i++)
    {
        number *= A;               // number = number * A
    }
    return number;                 // потому что не void
}
int res = Chisla (ReadInt(), ReadInt());    //Вызываем метод. Два раза вводим числа (А и В)
Console.WriteLine(res);