//Задача 40: Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник с сторонами такой длины.


using static System.Console;
Clear();

WriteLine("Введите длину стороны А: ");
int a = int.Parse(ReadLine());
WriteLine("Введите длину стороны B: ");
int b = int.Parse(ReadLine());
WriteLine("Введите длину стороны C: ");
int c = int.Parse(ReadLine());

if((a+b)>c&&(a+c)>b&&(b+c)>b)
{
    WriteLine("Можно построить треугольник");
}
else{
    WriteLine("Треугольник не существует");
}
