//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Write("Введите число: ");
string line = Console.ReadLine() ?? "0";
char[] digits = line.ToCharArray();
if (line.Length > 2)
{
    Console.WriteLine(digits[2]);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}