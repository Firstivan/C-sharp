// SЗадача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

// Console.WriteLine("Enter a any number:");
// string? n = Console.ReadLine();
// int number = Convert.ToInt32(n);

// int SizeNumber = n.Length;

// Console.WriteLine(SizeNumber);
// __________________________________________

//Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

// Console.WriteLine("Enter a any number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// for (int i = 1; i <= number; i++)

// {
//     sum = sum + i;
    
// }
// Console.WriteLine(sum);
// __________________________________________

// Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.

// int [] array = new int [8];

// for ( int i = 0; i < array.Length; i++)
// {
//     array[i] = Random.Shared.Next(0, 2);
    
// }
// Console.Write(array[i] + "\t");
//_________________________________________

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Enter a any number");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while (number != 0)             //  245 //
{
    sum = sum + number % 10;    //  5   //4 //2
    number = number / 10;       //  24  //2 //0
}   
Console.WriteLine(sum);
//________________________________

// Задача №28. Произведение чисел от 1 до введенного числа

// Console.WriteLine("Enter a any number");
// int number = Convert.ToInt32(Console.ReadLine());
// int proizv = 1;

// for (int i = 1; i <= number; i++)
// {
//     proizv *=i;
// }
// Console.WriteLine(proizv);
// ____________________________________________________________________

// int numberA = new Random().Next(1, 10);     // Случайные числа от 1 до 10
// int numberB = Random.Shared.Next(11, 12);    // Случайные числа от 11 до 12
// Console.WriteLine(+(numberA + numberB));
//_______________________________________________________________
