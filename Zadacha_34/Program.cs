// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine("Задайте массив:  ");
int size = Convert.ToInt32(Console.ReadLine());
int [] collection = new int [size];
FillArray(collection);
Console.WriteLine ("массив: ");
PrintArray(collection);
int index = 0;

for (int A = 0; A < collection.Length; A++)
if (collection[A] % 2 == 0)
index++;

Console.WriteLine($"из {collection.Length} чисел, {index} - чётные");

void FillArray(int[] collection)
{
    for(int i = 0; i < collection.Length; i++)
    {
        collection[i] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] collection)
{
    Console.Write(" ");
    for(int i = 0; i < collection.Length; i++)
    {
        Console.Write(collection[i] + " ");
    }
    Console.Write(" ");
    Console.WriteLine();
}