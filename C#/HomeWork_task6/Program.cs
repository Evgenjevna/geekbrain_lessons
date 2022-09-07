using static System.Console;
Clear();
WriteLine("Введите число: ");
int a = int.Parse(ReadLine());
int b = a%2;
if (b == 0) {
    WriteLine("Введённое число чётное");
}
if (b == 1) {
    Write("Введённое число нечётное");
}