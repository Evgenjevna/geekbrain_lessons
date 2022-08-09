using static System.Console;
Clear();
int randomNumber = new Random().Next(100,999);
WriteLine(randomNumber);
int result = randomNumber / 100;
int thirdDigit = randomNumber %10;
Write(result);
Write(thirdDigit);