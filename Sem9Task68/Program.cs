// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

using System.Numerics;
// Ввод данных
BigInteger ReadData(string msg)
{
    Console.Write(msg);
    BigInteger num = BigInteger.Parse(Console.ReadLine() ?? "0");
    return num;
}
// Функция Аккермана c помощью рекурсии
BigInteger Ackermann(BigInteger m, BigInteger n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return Ackermann(m - 1, 1);
    }
    else
    {
        return Ackermann(m - 1, Ackermann(m, n - 1));
    }
}

BigInteger m = ReadData("введите m : ");
BigInteger n = ReadData("введите n : ");
BigInteger result = Ackermann(m, n);

Console.WriteLine("-------------");
Console.WriteLine($"Функция Аккермана для m = {m} и n = {n} равна {result}");

