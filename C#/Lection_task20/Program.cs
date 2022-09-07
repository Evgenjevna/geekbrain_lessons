//Нахождение расстояния между двумя точками в 2D пространстве 
using static System.Console;
Clear();
WriteLine("Введите координаты точки А ");
int x1 = Convert.ToInt32(ReadLine());
int y1 = Convert.ToInt32(ReadLine()); 

WriteLine("Введите координаты точки B ");
int x2 = Convert.ToInt32(ReadLine());
int y2 = Convert.ToInt32(ReadLine());

int a = x2 - x1;
int b = y2 - y1;

int c = a * a + b * b;
double result = Math.Sqrt(c);
WriteLine($"Отрезок равен {result:f2}");