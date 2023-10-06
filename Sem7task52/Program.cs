// №52 Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом
// столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
// * Дополнительно вывести среднее арифметическое по диагоналям и диагональ выделить разным
// цветом.

// Решение с * ,но тут только основная и побочная разными цветами.

// int ReadData(string msg) // вводим данные
// {
//     Console.WriteLine(msg);
//     int num = int.Parse(Console.ReadLine() ?? "0");
//     return num;
// }
// // Заполнение случайными числами
// int[,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder)
// {
//     int[,] array2D = new int[countRow, countColumn];
//     for (int i = 0; i < countRow; i++)
//     {
//         for (int j = 0; j < countColumn; j++)
//         {
//             array2D[i, j] = new Random().Next(downBorder, topBorder + 1);
//         }
//     }
//     return array2D;
// }
// // вывод матрицы с цветным и диаганалями
// void PrintArray (int [,] matrix)
//     {

//     ConsoleColor mainDiagColor = ConsoleColor.Yellow;
//     ConsoleColor secondDiagColor = ConsoleColor.DarkBlue;
//     ConsoleColor defaultColor = ConsoleColor.Gray;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.ForegroundColor = 
//             (i == j)? mainDiagColor:
//             (i+j == matrix.GetLength(1)-1)?secondDiagColor: 
//             defaultColor;
//             Console.Write(matrix[i,j]+"\t");
//             Console.ResetColor();
//         }
//         Console.WriteLine();
//     }
// }
//   // Печать средних по столбцам
//   void  PrintListAvr (double [] list)
//     {
//       Console.WriteLine("The averages in columns are: ");
//       for(int i = 0; i < list.Length; i++)
//         Console.Write(list[i].ToString("0.00")+"\t");

//         Console.WriteLine();    
//     }
//   // Поиск средних по столбцам
//   double [] FindAverageInColumns (int [,] matrix)
//     { 
//       double[] result = new double[matrix.GetLength(1)];
//       for(int j = 0; j < matrix.GetLength(1); j++)
//       {
//         result[j] = 0;
//         for(int i = 0; i < matrix.GetLength(0); i++)
//         {
//           result[j] +=matrix[i,j];
//         }
//         result[j]/=matrix.GetLength(0);
//       }
//       return result;
//     }
// //Поисх средних по диаганалями
// double[] AveragesInDiaganals(int [,] matrix)
// {

//     double[] result = {0,0};
//     int numVal = matrix.GetLength(1) < matrix.GetLength(0) ? matrix.GetLength(1): matrix.GetLength(0);
//     for(int j = 0; j < matrix.GetLength(1); j++) // пробегаем по диаганалям
//     {
//          if(j < numVal) 
//            result[0] += matrix[j,j]; // накладываем условия, чтобы не вылезти за границы
//          if(matrix.GetLength(0) > matrix.GetLength(1)-1-j) // накладываем условия, чтобы не вылезти за границы
//             result[1] += matrix[matrix.GetLength(1)-1-j, j]; 
//     }
//     result[0]/=numVal;
//     result[1]/=numVal;
//     return result;
// }
// //печать средних по диаганалям
//  void  PrintDiagAverages (double [] diagAvg)
//     {
//         Console.WriteLine($"Среднее на главной диаганали: {diagAvg[0].ToString("0.00")}, а среднее по побочной: {diagAvg[1].ToString("0.00")}");
//     }


//    Console.Clear();
// int n = ReadData("Введите количество строк");
// int m = ReadData("Введите количество стобцов");
// int[,] arr2D = Fill2DArray(n,m,10,-10);
// PrintArray(arr2D);
// double[] avgArr = FindAverageInColumns(arr2D);
// PrintListAvr(avgArr);
// double[] avgDiag = AveragesInDiaganals(arr2D);
// PrintDiagAverages(avgDiag);



// Решение задачи с *


// // Ввод парметров матрицы.
// int rowCount = ReadInt("Введите количество строк m: ");
// int colCount = ReadInt("Введите количество cтолбцов n: ");

// // Генерация матрицы.
// int minValue = 0;
// int maxValue = 9;
// int[,] matrix = CreateRandomMatrix(rowCount, colCount, minValue, maxValue);

// // Поиск среднего арифметического по диагоналям.
// double[] averageValues = FindAverages(matrix);

// // Создание цветового набора для вывода результатов.
// int countDiagonals = matrix.GetLength(1) + matrix.GetLength(0) - 1;
// ConsoleColor[] diagonalsColors = CreateConsoleColorArray(countDiagonals);

// // Вывод матрицы и результатов подсчета на экран.
// PrintMatrixColoredDiagonals("\nСгенерированный массив: ", matrix, diagonalsColors);
// AverageValuesOutput(averageValues, diagonalsColors);

// //                                                     Методы
// //------------------------------------------------------------------------------------------------------------------

// // Ввод целого числа с клавиатуры.
// int ReadInt(string msg)
// {
//     Console.Write(msg);
//     return int.Parse(Console.ReadLine() ?? "0");
// }

// // Генераци двумерного массива, заполненного случайными целыми значениями.
// int[,] CreateRandomMatrix(int rowCount, int colCount, int minValue, int maxValue)
// {
//     Random random = new Random();
//     int[,] matrix = new int[rowCount, colCount];

//     // Опередление значений массива
//     for (int i = 0; i < rowCount; i++)
//     {
//         for (int j = 0; j < colCount; j++)
//         { matrix[i, j] = random.Next(minValue, maxValue + 1); }
//     }

//     return matrix;
// }

// // Поиск среднего арифметического каждой диагонали
// double[] FindAverages(int[,] matrix)
// {
//     // Используемые переменные
//     int countDiagonals = matrix.GetLength(1) + matrix.GetLength(0) - 1;
//     int rowCount = matrix.GetLength(0);
//     int colCount = matrix.GetLength(1);

//     double[] averageValues = new double[countDiagonals];

//     // Поиск среднего арифметического 
//     for (int i = 0; i < countDiagonals; i++)
//     {
//         int sum = 0;
//         int count = 0;

//         int col = (i < colCount) ? i : colCount - 1;
//         int row = (i < colCount) ? 0 : i - colCount + 1;

//         while (row < rowCount && col >= 0 )
//         {
//             sum += matrix[row, col];
//             count++;
//             col--;
//             row++;
//         }

//         averageValues[i] = (double)sum / count;
//     }

//     return averageValues;
// }

// // Получение набора цветов для дигоналей
// ConsoleColor[] CreateConsoleColorArray(int length)
// {
//     Random random = new Random();
//     ConsoleColor[] colors = (ConsoleColor[])Enum.GetValues(typeof(ConsoleColor));

//     // Заполнение массива цветов
//     ConsoleColor[] newColors = new ConsoleColor[length];
//     for (int i = 0; i < length; i++) { newColors[i] = colors[i % colors.Length]; }
//     return newColors;
// }

// // Выводит элементы массива в консоль
// void PrintMatrixColoredDiagonals(string message, int[,] matrix, ConsoleColor[] matrixColors)
// {
//     Console.WriteLine(message);

//     int rowCount = matrix.GetLength(0);
//     int colCount = matrix.GetLength(1);

//     for (int i = 0; i < rowCount; i++)
//     {
//         for (int j = 0; j < colCount; j++)
//         {
//             Console.ForegroundColor = matrixColors[i + j];
//             Console.Write($"{matrix[i, j],4}");
//         }
//         Console.WriteLine();
//     }
//     Console.ResetColor();
// }

// // Выводит массив со средними значениями
// void AverageValuesOutput(double[] averageValues, ConsoleColor[] matrixColors)
// {
//     Console.WriteLine();
//     Console.WriteLine("Средние значения диагоналей:");

//     for (int i = 0; i < averageValues.Length; i++)
//     {
//         Console.ForegroundColor = matrixColors[i];
//         Console.Write($"[{i}]:{averageValues[i]:F2}  ");
//     }
//     Console.ResetColor();
// }


// Решение обычной задачи

using System;

public class Answer
{
    public static void PrintArray(int[,] matrix)
    {
        // Введите свое решение ниже
        int rows = matrix.GetLength(0); int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }

    }

    public static int[,] CreateIncreasingMatrix(int n, int m, int k)
    {
        // Введите свое решение ниже
        int[,] matrix = new int[n, m]; int count = 1;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = count;
                count += k;
            }
        }

        return matrix;

    }

    static void PrintListAvr(double[] list)
    {
        // Введите свое решение ниже
        Console.Write("The averages in columns are: ");
        Console.WriteLine();
        foreach (double num in list) { Console.Write(num.ToString("0.00") + "\t"); }
        Console.WriteLine();

    }

    static double[] FindAverageInColumns(int[,] matrix)
    {
        // Введите свое решение ниже
        int rows = matrix.GetLength(0); int cols = matrix.GetLength(1);

        double[] averages = new double[cols];

        for (int j = 0; j < cols; j++)
        {
            double sum = 0;
            for (int i = 0; i < rows; i++)
            {
                sum += matrix[i, j];
            }
            averages[j] = sum / rows;
        }

        return averages;

    }


    // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args)
    {
        int n, m, k;

        if (args.Length >= 3)
        {
            n = int.Parse(args[0]);
            m = int.Parse(args[1]);
            k = int.Parse(args[2]);
        }
        else
        {
            // Здесь вы можете поменять значения для отправки кода на Выполнение
            n = 3;
            m = 4;
            k = 2;
        }

        // Не удаляйте строки ниже
        int[,] result = CreateIncreasingMatrix(n, m, k);
        PrintArray(result);
        PrintListAvr(FindAverageInColumns(result));
    }
}