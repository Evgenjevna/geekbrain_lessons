//Вводим номер четверти кординатной плоскости, получаем диапазон значений X и Y в данной четверти
using static System.Console;
Clear();

WriteLine("Введите число: ");
int a = Convert.ToInt32(ReadLine());
switch (a)
{
    case 1:
        {
            WriteLine("X > 0 и Y > 0");
            break;
        }
    case 2:
        {
            WriteLine("X < 0 и Y > 0");
            break;
        }
    case 3:
        {
            WriteLine("X < 0 и Y < 0");
            break;
        }
    case 4:
        {
            WriteLine("X > 0 и Y < 0");
            break;
        }
         default: {
    WriteLine("Нет такой четверти");
    break;}
}
