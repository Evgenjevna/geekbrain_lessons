// Проверка 5-ти значного, является ли оно полиндромом
using static System.Console;
Clear();
WriteLine("Введите 5-ти значное число: ");
//Решение задачи через строку
string UsersInput = ReadLine();
int n = UsersInput.Length;
if (n == 5)
{
    if (UsersInput[0] == UsersInput[4] && UsersInput[1] == UsersInput[3])
    {
        WriteLine("Да");
    }
    else
    {
        WriteLine("Нет");
    };
}
else
{
    WriteLine("Введено неверной количество цифр");
}