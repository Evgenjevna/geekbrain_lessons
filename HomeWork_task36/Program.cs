/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

using static System.Console;
Clear();
int[] even = GetArray(15, -100, 100);
WriteLine($"Массив: [{String.Join(",", even)}]");
int N = 0;
for (int i = 0; i < even.Length; i++){
    if (i % 2 == 0)
        N=N+even[i];
}
WriteLine($"Сумма элементов стоящих на нечётных позициях в массиве: {N}");

int[] GetArray(int size, int minValue, int maxValue){
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}