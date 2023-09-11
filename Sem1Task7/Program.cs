// Задача 7
// Напишите программу,которая принимает на вход трёхзначное число и
// на выходе показывает последнюю цифру этого числа.

// int num = int.Parse(Console.ReadLine() ?? "0");
// // if (num ToString().Length == 3); медленный оператор
// if (num > 100 && num < 1000)
// {
//     int lastDigit = num % 10;
//     Console.WriteLine("Последняя цифра " + num + " это: " + lastDigit);
// }
// else
// {
//     Console.WriteLine("Число не трёхзначное");
// }

// Console.WriteLine("Введите число:");
// int num = int.Parse(Console.ReadLine() ?? "0");

// Console.WriteLine(num < 1000 && num > 99 ? num % 10 : "Число не трёхзначное");

Console.WriteLine("Enter the number: ");
int num = int.Parse(Console.ReadLine() ?? "0");

if (num > 99 && num < 1000)
{
    int lastNum = num % 10;
    Console.WriteLine("Last number " + num + " This " + lastNum);
}
else
{
    Console.WriteLine("The number is not three digits");
}