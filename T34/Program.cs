// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}
int[] FillPositiveArray3v(int length)
{
    int[] result = new int[length];
    for (int i = 0; i < length; i++)
    {
        result[i] = new Random().Next(100, 1000);
    }
    return result;
}
int NumberOfEven (int[]array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {  
        if(array[i]%2 == 0) count++; 
    }
    return count;
}

Console.Write("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int [] array = FillPositiveArray3v(length);
PrintArray(array);
Console.WriteLine();
Console.Write($"Количество четных чисел в массиве = {NumberOfEven(array)}");