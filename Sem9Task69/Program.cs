// Задача 69.
// Напишите программу, которая будет принимать 2 числа A и B.
// Возведите A в степень B с помощью рекурсии.



// метод рекурсии,но легкий(1)Легкий для чтения кода

// long RecPow(int a, int b)
// {
//     long res = 1;
//     if (b <= 0)
//     {
//         return 1;
//     }
//     else
//     {
//         res = a * RecPow(a, b-1)
//     }
//     return res;
// }



// Вывод сообщения и запись введённых данных
int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine() ?? ",";
    int number = Convert.ToInt32(value);

    return number;
}
// Считает сумму(1) чуть более сложный для чтения кода
int Exponentiation(int number, int stepen)
{
    return stepen <= 0 ? 1 : number * Exponentiation(number, stepen - 1);
}

// Считает сумму(2) сложный для чтения кода
int Exponentiation1(int number, int stepen)
{
    return stepen == 2
    ? number * number
    : stepen <= 1
        ? number
        : stepen % 2 == 0
            ? Exponentiation1(number, stepen / 2) * Exponentiation1(number, stepen / 2)
            : Exponentiation1(number, stepen / 2 + 1) * Exponentiation1(number, stepen / 2);
}

// Считает сумму(2) легкий  для чтения кода . код чуть быстрее (1) на больших обьемах данных.
long MyPow(int a, int b)
{
    if (b == 2) return a * a;
    if (b == 1) return a;

    if (b % 2 == 0)
    {
        return MyPow(a, b / 2) * MyPow(a, b / 2);
    }
    else
    {
        return MyPow(a, b / 2) * MyPow(a, b / 2 + 1);
    }
}


int number = Prompt("Введите число: ");
int stepen = Prompt("Введите степень: ");

Console.WriteLine($"Число {number} в степени {stepen} = {Exponentiation(number, stepen)}");
Console.WriteLine($"Число {number} в степени {stepen} = {MyPow(number, stepen)}");

