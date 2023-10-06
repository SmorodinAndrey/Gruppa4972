// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// 1)ReadData
// 2)Fill2DArray
// 3)Print2DArray
// 4)SortArr


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
    Random random = new Random();

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = random.Next(downBorder, topBorder + 1);
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
// Сортируем элементы массива по убыванию
void SortArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = j + 1; k < arr.GetLength(1); k++)
            {
                if (arr[i, j] < arr[i, k])
                {
                    int temp = arr[i, j];
                    arr[i, j] = arr[i, k];
                    arr[i, k] = temp;
                }
            }
        }
    }
}


int n = ReadData("Введите количество строк: "); //входные данные
int m = ReadData("Введите количество столбцов: "); //входные данные
int[,] matrix = Fill2DArray(n, m, 10, 1);
Console.WriteLine("Начальный массив:");
Print2DArray(matrix); //выводим начальный массив
Console.WriteLine("-----------------------------------------");
SortArr(matrix); //метод сортировки массива
Console.WriteLine("Массив после сортировки по убыванию:");
Print2DArray(matrix); // выводим массив после сортировки

