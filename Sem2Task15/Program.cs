//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
System.Console.WriteLine("Введите номер");
int a = Convert.ToInt32(Console.ReadLine());
switch (a)
{
    case 1:
        Console.WriteLine("Рабочий");
        break;

    case 2:
        Console.WriteLine("Рабочий");
        break;

    case 3:
        Console.WriteLine("Рабочий");
        break;

    case 4:
        Console.WriteLine("Рабочий");
        break;

    case 5:
        Console.WriteLine("Рабочий");
        break;

    case 6:
        Console.WriteLine("Выходной");
        break;

    case 7:
        Console.WriteLine("Выходной");
        break;
    default: Console.WriteLine("Неверные данные"); break;
}