/*Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)   */

using static System.Console;
using System.Linq;
Clear();

int[,,] cube = GetTensor(2, 2, 2);   //Задание размера трёхмерного массива (2х2х2)

PrintTensor(cube);

int[,,] GetTensor(int rows, int colums, int depth)  //Генерация рандомного интового трёхмерного массива числами от 0 до 100
{
    int[,,] result = new int[rows, colums, depth];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            for (int k = 0; k < depth; k++)
            {
                result[i, j, k] = new Random().Next(0, 100) + 1;
            }
        }
    }
    return result;
}



void PrintTensor(int[,,] cube) //Вывод массива на экран
{
    for (int i = 0; i < cube.GetLength(0); i++)
    {
        for (int j = 0; j < cube.GetLength(1); j++)
        {
            for (int k = 0; k < cube.GetLength(2); k++)
            {
                Write($"{cube[i, j, k]}({i = 0 + i}, {j = 0 + j}, {k = 0 + k})" + "\t");    //Вывод значений элементов массива и кординат каждого элемента
            }
            WriteLine();
        }
    }
}