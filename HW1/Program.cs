/*
//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.Write("Input first integer number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second integer number: ");
int b = Convert.ToInt32(Console.ReadLine());

int max = a;

if (b > max) max = b;

int min = b;

if (a <= min) min = a;

Console.Write("max = ");
Console.WriteLine(max);
Console.Write("min = ");
Console.WriteLine(min);
*/

/*
//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.Write("Input first integer number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second integer number: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Input third integer number: ");
int c = Convert.ToInt32(Console.ReadLine());

int max=a;

if (b > max) max = b;
if (c > max) max = c;

Console.Write("max = ");
Console.WriteLine(max);
*/

/*
//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

//4 -> да
//-3 -> нет
//7 -> нет

Console.WriteLine("Введите число : ");
int a = Convert.ToInt32(Console.Read());

if (a % 2 == 0) Console.WriteLine("Да");
else Console.WriteLine("Нет");
Console.ReadKey();
*/

/*
//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.WriteLine("Введите число : ");
int n=int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
     if (i % 2 == 0) Console.Write(" " + i);
}
Console.ReadKey();
*/
