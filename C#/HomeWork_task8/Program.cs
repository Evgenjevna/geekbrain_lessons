using static System.Console;
Clear();
WriteLine("Введите число: ");
int a = int.Parse(ReadLine());
int i = 1;
while (i <= a){
    if (i%2==0)
    WriteLine(i);  
i++;
}