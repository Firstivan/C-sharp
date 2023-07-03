
//Задача 25: Напишите функцию, которая принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B. НЕ ИСПОЛЬЗОВАТЬ MATH.POW()

int Prompt(string message)                                       //Обозначаем метод для ввода числа
{
    System.Console.Write(message);          //Выводим на экран
    string readInput = System.Console.ReadLine();
    int result = int.Parse (readInput);    //Конвертирупм введённую с троку в число
    return result;                                       // потому что не void (возвращаем метод)
}

int Power (int powerBase, int exponent)          //Задали функцию которая принимает два числа
{
    int power = 1;
    for(int i = 0; i < exponent; i++)
    {
        power *= powerBase;               // number = number * A
    }
    return power;                 // потому что не void
 }

bool ValidateExponent (int exponent)
{
    if (exponent < 0)
    {
        System.Console.WriteLine("Показатель не должен быть меньше нуля!");
        return false;
    }
    return true;
}

int powerBase = Prompt("Введите основание: "); 
int powerExponent = Prompt("Введите показатель: ");
if (ValidateExponent(exponent))
{
    System.Console.WriteLine($"Число {powerBase} в степени {exponent} равно: {Power(powerBase, exponent)}");
}