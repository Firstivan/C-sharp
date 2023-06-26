// Задача №28. 
// Произведение чисел от 1 до введенного числа

int ReadInt()
{
Console.WriteLine("Введите целое число!");          //Выводим на экран
int value = Convert.ToInt32(Console.ReadLine());    //Конвертирупм введённую с троку в число
return value;   // потому что не void (возвращаем метод)
}

int proizv(int number)
{
    int result = 1;
    for (int i = 1; i <= number; i++)
    {
        result*=i;
    }
    return result; // потому что не void
}
int number = ReadInt();
int proizv1 = proizv(number);
Console.WriteLine($"Произведение всех цифр в этом числе = {proizv1}");