// Задача 56: Задайте прямоугольный двумерный массив.
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// 1)Readata
// 2)Fill2dArray
// 3)Print2DArray
// 4)MinSumRow
int ReadData(string msg) // вводим данные
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}
// Генерируем элементы массива
int[,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder)
{
    int[,] array2D = new int[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = new Random().Next(downBorder, topBorder + 1);
        }
    }
    return array2D;
}
// Вывод двумерного массива
void Print2DArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
//Метод по выводу номера строки с наименьшей суммой элементов
int MinSumRow(int[,] arr, ref int sumMin)
{
    sumMin = 0;
    int numN = 0;

    for (int j = 0; j < arr.GetLength(1); j++)
    {
        sumMin += arr[numN, j];
    }
    for (int i = 1; i < arr.GetLength(0); i++)
    {
        int rowSum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            rowSum += arr[i, j];
        }
        if (rowSum < sumMin)
        {
            sumMin = rowSum; // находим сумму
            numN = i;        // находим строку с наименьшей суммой элементов
        }
    }
    return numN;
}
int n = ReadData("Введите количество строк: "); //входные данные
int m = ReadData("Введите количество столбцов: "); //входные данные
int[,] arr = Fill2DArray(n, m, 10, 1);
int sumMin = 0;
int numN = MinSumRow(arr, ref sumMin);

Console.WriteLine("Массив:");
Print2DArray(arr); //выводим  массив
Console.WriteLine("Номер строки с минимальной суммой: " + (numN + 1));
Console.WriteLine("Сумма равна :" + sumMin);


