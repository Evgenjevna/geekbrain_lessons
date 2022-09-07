using static System.Console;
Clear();
int GetRandomNumberInRange(int minNumber, int maxNumber);
{
    int result = new Random().Next(minNumber,maxNumber);
    return result;
}
int GetMaxDigitFromNumber(int number)
{
    int result = number / 10;
    int secondDigit = number % 10;
    if(secondDigit > result)
    {
        result = secondDigit;
    }
    return result;
}
int randomNumber = GetRandomNumberInRange(10,99);
int maxDigit = GetMaxDigitFromNumber(randomNumber);
WriteLine("Наибольшая цифра числа {randomNamber} является {maxDigit}");