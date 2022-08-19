//Напишите цикл, который принимает на вход два числа 
//(A и B) и возводит число A в натуральную степень B.

using static System.Console;
Clear();
Write("Введите число А = ");
int A = Convert.ToInt32(ReadLine());
Write("Введите число B = ");
int B = Convert.ToInt32(ReadLine());
int C = GetRais(A,B);
WriteLine($"Возведение числа {A} в степень {B} = {C}");

int GetRais(int number1, int number2)
{
int result = number1;
for (int i = 2; i <= number2; i++){
    result *=number1;
    }
return result;
}