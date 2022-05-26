// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

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
int[] FillArray(int length, int deviation)
{
    int[] result = new int[length];
    for (int i = 0; i < length; i++)
    {
        result[i] = new Random().Next(-deviation, deviation + 1);
    }
    return result;
}
int MinMaxDiff(int[] array)
{
    int min = 0;
    int max = 0;
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
        else if (array[i] > max) max = array[i];
    }
result = max-min;
return result;
}

Console.Write("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите диапазон массива (массив будет от - до + вашего значения): ");
int deviation = Convert.ToInt32(Console.ReadLine());
if (deviation < 0) deviation = deviation * -1;
int[] array = FillArray(length, deviation);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным элементов массива: {MinMaxDiff(array)}");