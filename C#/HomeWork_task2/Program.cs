using static System.Console;
Clear();
WriteLine("Введите первое число: ");
int a = int.Parse(ReadLine());
WriteLine("Введите второе число: ");
int b = int.Parse(ReadLine());
if (a>b){
Write("Max = ");
WriteLine(a);
Write("Min = ");
Write(b);}
else{
Write("Max = ");
WriteLine(b);
Write("Min = ");
Write(a);
}