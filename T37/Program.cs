// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21
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
void MultOfSideI(int[] array)
{
    int result = 1;
    for (int i = 0; i < array.Length/2; i++)
    {
        result = array[i] * array[array.Length-1-i];
        Console.WriteLine($"{array[i]} x {array[array.Length-1-i]} = {result} ");
    }
}
Console.Write("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите диапазон массива (массив будет от - до + вашего значения): ");
int deviation = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(length, deviation);
PrintArray(array);
Console.WriteLine();
Console.WriteLine();
MultOfSideI(array);