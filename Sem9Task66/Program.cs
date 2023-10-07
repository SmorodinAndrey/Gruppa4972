// Задача 66: Задайте значения M и N.
// Напишите программу, которая найдёт сумму натуральных элементов
// в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Ввод данных
int ReadData(string msg)
{
    Console.Write(msg);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}
// Вычисляем сумму в промежутке от M до N
int SumInInterval(int m, int n)
{
    if (n > m)
    {
        int sum = n; n = m; m = sum;
    }
    if (m > n)
    {
        return m + SumInInterval(n, m - 1);
    }
    else
    {
        return n;
    }
}
int m = ReadData("Введите M : ");
int n = ReadData("Введите N : ");
int sum = SumInInterval(m, n);

Console.WriteLine($"Сумма в промежутке от {m} до {n} равнa : {sum}");
