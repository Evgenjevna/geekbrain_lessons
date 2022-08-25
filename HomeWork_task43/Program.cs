/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
Пример:
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/


using static System.Console;
Clear();
WriteLine("Введите значение b1");
int b1 = int.Parse(ReadLine());
WriteLine("Введите значение k1");
int k1 = int.Parse(ReadLine());
WriteLine("Введите значение b2");
int b2 = int.Parse(ReadLine());
WriteLine("Введите значение k2");
int k2 = int.Parse(ReadLine());
int x = (b2 - b1)/(k1-k2);
int y = k1 * x + b1;
WriteLine($"Кординаты точки пересечения прямых: ({x:f1} ; {y:f1})");