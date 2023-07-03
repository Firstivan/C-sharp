Console.WriteLine("Ищем остаток. Введите число"); //Пример 79/10=7 (остаток 9)
String? aa = Console.ReadLine();
double number = Convert.ToInt32(aa); //TrueNumber

// double number = TrueNumber / 10;
// Console.WriteLine("Для начала разделим число на 10 и получим " + number);

double number2 = number % 2;
Console.WriteLine("Остаток % 2 - " + number2);

double number3 = number % 3;
Console.WriteLine("Остаток % 3 - " + number3);

double number5 = number % 5;
Console.WriteLine("Остаток % 5 - " + number5);

double number10 = number % 10;
Console.WriteLine("Остаток % 10 c переменной double - " + number10);

// int number101 = number % 10;
// Console.WriteLine("Остаток % 10 c переменной int - " + number101);

double number20 = number % 20;
Console.WriteLine("Остаток % 20 - " + number20);

double number100 = number % 100;
Console.WriteLine("Остаток % 100 - " + number100);