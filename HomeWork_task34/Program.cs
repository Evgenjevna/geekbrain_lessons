/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2*/

using static System.Console;
Clear();
int[] even = GetArray(8, 100, 999);
WriteLine($"Массив: [{String.Join(",", even)}]");
int N = 0;
for (int i = 0; i < even.Length; i++){
    if (even[i] % 2 == 0)
        N+=1;
}
WriteLine($"Количество чётных элементов в массиве: {N}");

int[] GetArray(int size, int minValue, int maxValue){
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}