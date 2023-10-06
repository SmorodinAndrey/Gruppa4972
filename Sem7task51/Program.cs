// Задача №51
// Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12



// Вывод сообщения и запись введённых данных
int ReadData(string msg) // вводим данные
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}
// Вывод результата
void PrintData(string msg)
{
    Console.WriteLine(msg);
}
// Заполняет массив случайными цифрами
void Fill2DArray(int[,] array, int minElement, int maxElement)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(minElement, maxElement);
}
// Ищет элементы, у которых оба индекса чётные и сумирует их
int MainDiagSum(int[,] array)
{
    int sum = 0;

    for (int i = 0; i < array.GetLength(0) && i < array.GetLength(1); i++)
        sum += array[i, i];

    return sum;
}

// Выводит элементы массива в консоль
void Print2DArray(int[,] array, string message)
{
    Console.WriteLine(message);

    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[");

        for (int j = 0; j < array.GetLength(1) - 1; j++)
            Console.Write(array[i, j] + "\t");

        Console.WriteLine(array[i, array.GetLength(1) - 1] + "]");
    }
}

int m = ReadData("Введите m: ");
int n = ReadData("Введите n: ");
int minElement = 0;
int maxElement = 10;

int[,] array = new int[m, n];

Fill2DArray(array, minElement, maxElement);
Print2DArray(array, "Массив: ");
PrintData("Сумма эл-тов главной диагонали: " + MainDiagSum(array));