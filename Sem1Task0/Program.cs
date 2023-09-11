// Задача 0
// Напишите программу, которая на вход принимает число и
// выдает его квадрат (число умноженное на само себя).

Console.WriteLine("Введите число: ");
//Считываем данные с консоли
string? inputNum = Console.ReadLine();//??"0";
if (inputNum != null)
//Проверяем, чтобы данные были не пустыми
{
    // Парсим введенное число
    // int num = int.Parse(inputNum);
    // Находим квадрат числа
    // int res = num*num;
    // Выводим данные в консоль
    // Console.WriteLine(res);

    Console.WriteLine("Квадрат числа: " + (int)Math.Pow(int.Parse(inputNum), 2));
}