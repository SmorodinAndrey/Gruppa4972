// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите два числа: ");
int numA = int.Parse(Console.ReadLine() ?? "0");
int numB = int.Parse(Console.ReadLine() ?? "0");
if (numB > numA)
{
    System.Console.WriteLine("Наибольшее число: " + numB);
    System.Console.WriteLine("Наименьшее число: " + numA);
}
else
{
    System.Console.WriteLine("Наибольшее число: " + numA);
    System.Console.WriteLine("Наименьшее число: " + numB);
}