// int number = 8;
// int [] array = new int [number];
// // int value = array [0];      //
// // array [0] = value;

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = Random.Shared.Next(0, 2);
//     Console.Write(array[i]);
// }

int [] array = new int [8];     // array это имя массива. new это выделение памяти. 
for (int i = 0; i < array.Length; i++)
{
    array[i] = Random.Shared.Next(0, 2);
    Console.Write(array[i] + "\t");
}

// ____________________________________________________________________

// int numberA = new Random().Next(1, 10);     // Случайные числа от 1 до 10
// int numberB = Random.Shared.Next(11, 12);    // Случайные числа от 11 до 12
// Console.WriteLine(+(numberA + numberB));
//_______________________________________________________________


