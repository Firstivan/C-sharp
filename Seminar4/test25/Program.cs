
//Задача 25: Напишите функцию, которая принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B. НЕ ИСПОЛЬЗОВАТЬ MATH.POW()

using System;

class Program
{
    static int ReadInt()
    {
        Console.WriteLine("Введите целое число:");
        int value = Convert.ToInt32(Console.ReadLine());
        return value;
    }


    static int Power(int A, int B)
    {
        int result = 1;
        for (int i = 1; i < B; i++)
        {
        result *= A;
        }
        return result;
    }

    static bool ValidateB(int B)
    {
        if (B < 0)
        {
            Console.WriteLine("Второе число не должно быть мельше нуля!");
            return false;
        }
        return true;
    }

    static void Main(string[] args)
    {
        int A = ReadInt();
        int B = ReadInt();

    if (ValidateB(B))
        {
            int result = Power(A, B);
            Console.WriteLine(result);
        }
    }
}
