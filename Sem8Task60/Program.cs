// // Задача 60:Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// // Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// // Массив размером 2 x 2 x 2

// 1)ReadData
// 2)Fill3DArray
// 3)Print3DArray

int ReadData(string msg) // вводим данные
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}
// Генерируем элементы массива
int[,,] Fill3DArray(int rows, int columns, int height)
{
    int[,,] array = new int[height, rows, columns];
    int res = 10;
    for (int n = 0; n < height; n++)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                array[n, i, j] = res;
                res++;
            }
        }
    }
    return array;
}
// Вывод трёхмерного массива
void Print3DArray(int[,,] arr)
{
    for (int m = 0; m < arr.GetLength(0); m++)
    {
        for (int i = 0; i < arr.GetLength(1); i++)
        {
            for (int j = 0; j < arr.GetLength(2); j++)
            {
                Console.Write($"{arr[m, i, j]}({m},{i},{j}) ");
            }

            Console.WriteLine();
        }
    }
}
int l = ReadData("Задайте количество слоев: "); //ввод данных
int n = ReadData("Задайте количество строк: "); //ввод данных
int m = ReadData("Задайте количество столбцов: "); //ввод данных
int[,,] arr3D = Fill3DArray(l, n, m);

Console.WriteLine("Вывод трехмерной матрицы");
Print3DArray(arr3D); //вывод массива


