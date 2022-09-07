using static System.Console;
Clear();
WriteLine("Введите число: ");
int addNumber = Convert.ToInt32(Console.ReadLine());

int constanteOne = 7;
int constanteTwo = 23;

if (addNumber % constanteOne == 0 && addNumber % constanteTwo == 0)
{
    WriteLine("Число кратно 7 и 23");
}
else
{
 
    WriteLine("Число не кратно 7 и 23");
}
