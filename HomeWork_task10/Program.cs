using static System.Console;
Clear();
WriteLine("Введите число: ");
int a = int.Parse(ReadLine());
if (a>=100 && a<=999) {
int b = a%100;
int c = b/10;
WriteLine(c);
}
else {
WriteLine ("Число не является трехзначным");
};