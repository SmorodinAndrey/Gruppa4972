// Задача 58: Задайте две матрицы.
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// 1)ReadData
// 2)Fill2Darray
// 3)PrintArray
// 4)ResultMatrix
// 5)MatrixSize

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
void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t ");
        }
        Console.WriteLine();
    }
}
// Метод произведения двух матриц
int ResultMatrix(int[,] matrixA, int[,] matrixB, int row, int column)
{
    int sum = 0;
    for (int i = 0; i < matrixA.GetLength(1); i++)
    {
        sum += matrixA[row, i] * matrixB[i, column];
    }
    return sum;
}
// Вычисляем размер результирующей матрицы
int[,] MatrixSize(int[,] matrixA, int[,] matrixB)
{
    int[,] res = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    for (int i = 0; i < res.GetLength(0); i++)
    {
        for (int j = 0; j < res.GetLength(1); j++)
        {
            res[i, j] = ResultMatrix(matrixA, matrixB, i, j);
        }
    }
    return res;
}

int n = ReadData("Введите количество строк первой матрицы"); // ввод данных
int m = ReadData("Введите количество столбцов первой матрицы"); // ввод данных
int[,] matrixA = Fill2DArray(n, m, 10, 1);
int[,] matrixB = Fill2DArray(m, n, 10, 1);
int[,] res = MatrixSize(matrixA, matrixB);

Console.WriteLine("Первая матрица: ");
PrintArray2D(matrixA);  //печать матриц
Console.WriteLine("Вторая матрица: ");
PrintArray2D(matrixB);  //печать матриц
Console.WriteLine("Результирующая матрица: ");
PrintArray2D(res);     // печать результирующей матрицы

