//                                 Задача 64
// Задайте значение N. Напишите программу, которая выведет все натуральные числа в 
// промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}
void GenLineRec(int num)
{
    Console.Write(num + " ");
    if (num <= 1)
    {
    }
    else
    {
        GenLineRec(num - 1);
    }
}

int num = ReadData("Введите число N: ");
GenLineRec(num);
