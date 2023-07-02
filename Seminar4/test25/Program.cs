
//Задача 25: Напишите функцию, которая принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B. НЕ ИСПОЛЬЗОВАТЬ MATH.POW()

int Prompt (string message)
{
    System.Console.WriteLine(message);
    string readInput = System.Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}

int Power(int powerBase, int exponent)
{
    int Power = 1;
    for (int i = 1; i < exponent; i++)
    {
    Power *= powerBase;
    }
    return Power;
}
dotnet
bool ValidateExponent(int exponent)
{
    if (exponent < 0)
    {
        Console.WriteLine("Второе число не должно быть мельше нуля!");
        return false;
    }
    return true;
}

int powerBase = Prompt("Введите целое число А");
int exponent = Prompt("Введите целое число Б");

if (ValidateExponent(exponent))
{
    System.Console.WriteLine($"число {powerBase} в степени {exponent} равно {Power (powerBase, exponent)}");
}