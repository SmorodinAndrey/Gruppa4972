//                                     Задача №27
// Напишите программу, которая принимает на вход число и
// выдаёт сумму цифр в числе.


// 1)ReadData
// 2)PrintResult
// 3)SumDigit


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
//Метод сложения цифр в числе
int SumDigit(int num)
{
    int res = 0;
    while (num > 0)
    {
        res += num % 10;
        num /= 10;
    }
    return res;
}

int num = ReadData("Введите число: ");

int res = SumDigit(num);

PrintResult($"Сумма чисел в числе = {res}");


