//                                     Задача №25
// Напишите цикл, который принимает на вход два числа (A и B) и
// возводит число A в натуральную степень B.


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
//Метод возведения в степень
long Mypow(int a, int b)
{
    long res = 1;
    while (b > 0)
    {
        res *= a;
        b -= 1;
    }
    return res;
}

int numberA = ReadData("Введите число A: ");
int numberB = ReadData("Введите число B: ");

long res = Mypow(numberA, numberB);

PrintResult($"Число A в степени B = {res}");




