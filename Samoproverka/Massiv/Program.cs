int number = 8;
int [] array = new int [number];
// int value = array [0];      //
// array [0] = value;

for (int i = 0; i < array.Length; i++)
{
    array[i] = Random.Shared.Next(0, 2);
    Console.WriteLine(array[i]);
}