/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3

Console.WriteLine ("Введите первое число:");
int a1 = int.Parse (Console.ReadLine()!);
Console.WriteLine ("Введите второе число:");
int a2 = int.Parse (Console.ReadLine()!);

if (a1 == a2)
{
    Console.WriteLine ($"Число {a1} равно числу {a2}");
}
else
{
    if (a1 > a2)
    {
       Console.WriteLine ($"Число {a1} больше, чем число {a2}"); 
    }
    else
    {
        Console.WriteLine ($"Число {a2} больше, чем число {a1}");
    }
}
*/

/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22

Console.WriteLine ("Введите первое число:");
int a1 = int.Parse (Console.ReadLine()!);
Console.WriteLine ("Введите второе число:");
int a2 = int.Parse (Console.ReadLine()!);
Console.WriteLine ("Введите третье число:");
int a3 = int.Parse (Console.ReadLine()!);

int max = a1;
if (a2 > max) max = a2;
if (a3 > max) max = a3;

Console.WriteLine ($"max = {max}");
*/
/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет

Console.WriteLine ("Введите число:");
int a = int.Parse (Console.ReadLine()!);

if (a%2 == 0)
{
    Console.WriteLine ($"Число {a} является четным.");
}
else
{
    Console.WriteLine ($"Число {a} не является четным.");
}
*/
/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8

Console.WriteLine ("Введите число N больше 0");
int N = int.Parse (Console.ReadLine()!);
int M = 2;

if (N <= 0) 
{
    Console.Write ("Вы ввели некорректное число N");
}
else
{
    if (N == 2)
    {
        Console.Write ("Четное число от 1 до 2 это 2");
    }
    else
    {
        Console.Write ($"Четные числа от 1 до {N}: ");

        while (M <= N)
        {
            Console.Write ($"{M}, ");
            M = M + 2;
        }
    }
}
*/
