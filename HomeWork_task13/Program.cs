using static System.Console;
Clear();
WriteLine("Введите число");
//Решение задачи через строку
//string UsersInput = ReadLine();
//int n = UsersInput.Length;
//if (n >= 3)
//{
//    WriteLine(UsersInput[2]);
//}
//else
//{
//    WriteLine("Число имеет меньше цифр");
//};

//Математическое решение решение
int n = int.Parse(ReadLine());
while (n > 999)
    n = n / 10;
int result = n % 10;
if (n > 99)
{
    WriteLine(result);
}
else
{
    WriteLine("Число имеет меньше цифр");
}