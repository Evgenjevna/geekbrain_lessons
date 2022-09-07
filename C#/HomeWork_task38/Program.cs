/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

using static System.Console;
Clear();
int[] even = GetArray(10, 1, 50);
WriteLine($"Массив: [{String.Join(",", even)}]");
int Min = even[0]; //Принимаем первый элемент массива за Минимальное значение
int Max = even[0]; //Принимаем первый элемент массива за Максимальное значение
foreach (int item in even)
{
     if(item > Max)
        {
        Max = item; //Находим максимальный элемент в массиве
        }
     if(item < Min)
        {
         Min = item; //Находим минимальный элемент в массиве
         }
}
WriteLine($"Разница между максимальным элементом массива {Max} и минимальным {Min} равна {Max - Min}");

int[] GetArray(int size, int minValue, int maxValue){ //Метод генерирует рандомный массив из 10 элементов от 1 до 50
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}