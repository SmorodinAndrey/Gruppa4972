// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число: ");
int numN = int.Parse(Console.ReadLine() ?? "0");
int evNumN = 2;
if (numN > 1)
{
    while (evNumN <= numN)
    {
        Console.Write(evNumN + " ");
        evNumN = evNumN + 2;
    }
}
