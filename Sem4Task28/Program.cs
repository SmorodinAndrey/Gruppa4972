//                                     Задача №28
// Напишите программу, которая принимает на вход число N 
// и выдаёт произведение чисел от 1 до N (факториал).
// Например:
// 4 -> 24
// 5 -> 120


// 1)ReadData
// 2)PrintResult
// 3)Factorial


using System.Numerics;

//Вводим данные
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

//Печатаем результат
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

//Считаем длину числа
BigInteger FactorialNum(int num)
{
    BigInteger result = 1;
    for (int i = 2; i <= num; i++)
    {
        result *= i;
    }
    return result;
}
int num = ReadData("Введите число");
BigInteger result = FactorialNum(num);
PrintResult($"Произведение чисел от 1 до {num} = {result}");
// PrintResult("Произведение чисел от 1 до " + num + " = " + result);
