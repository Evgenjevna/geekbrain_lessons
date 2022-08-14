//Нахождение расстояния между двумя точками в 3D пространстве
using static System.Console;
Clear();
WriteLine("Введите координаты точки А ");
int x1 = Convert.ToInt32(ReadLine());
int y1 = Convert.ToInt32(ReadLine()); 
int z1 = Convert.ToInt32(ReadLine());

WriteLine("Введите координаты точки B ");
int x2 = Convert.ToInt32(ReadLine());
int y2 = Convert.ToInt32(ReadLine());
int z2 = Convert.ToInt32(ReadLine());

int a = x2 - x1;
int b = y2 - y1;
int c = z2 - z1;

int d = a * a + b * b + c *c;
double result = Math.Sqrt(d);
WriteLine($"Отрезок равен {result:f2}");