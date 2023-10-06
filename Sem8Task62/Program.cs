// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// 1)FillArraySpiral
// 2)PrintArray

// Заполняем массив по спирали
void FillArraySpiral(int[,] array, int n)
{
    int i = 0, j = 0;
    int spiral = 1;
    for (int m = 0; m < n * n; m++)
    {
        int v = 0;
        do { array[i, j++] = spiral++; }
        while (++v < n - 1);
        for (v = 0; v < n - 1; v++)
            array[i++, j] = spiral++;
        for (v = 0; v < n - 1; v++)
            array[i, j--] = spiral++;
        for (v = 0; v < n - 1; v++)
            array[i--, j] = spiral++; ++i; ++j;
        n = n < 2 ? 0 : n - 2;
    }
}
// Метод для печати массива
void PrintArray(int[,] matrix)
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
int spr = 4;
int[,] arr = new int[spr, spr];

FillArraySpiral(arr, spr);
PrintArray(arr);


