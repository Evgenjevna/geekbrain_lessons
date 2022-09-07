/*Задача 32: Напишите программу замена элементов массива: 
положительные элементы замените на соответствующие отрицательные, и наоборот.*/

using static System.Console;
Clear();

int[] array = GetArray(12, -15, 15);
WriteLine($"[{String.Join(",", array)}]");

int[] array2 = Zamena(array);
WriteLine($"[{String.Join(",", array2)}]");


int[] Zamena(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = array[i] * (-1);
    return array;
}


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}