//                                     Задача №29
// Напишите программу, которая задаёт массив из 8 элементов и
//выводит их на экран.


// 1)ReadData
// 2)Creatarr
// 3)PrintArr


//Вводим данные
int ReadData(string msg)

{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}
//метод создания массива и получения случайных значений
int[] Creatarr(int Length, int minValue, int maxValue)
{
    int[] array = new int[Length];//обьявляем массив
    Random rnd = new Random();
    for (int i = 0; i < Length; i++)
    {
        array[i] = rnd.Next(minValue, maxValue + 1);//заполнение случайными числами из диапазона numA, numB
    }
    return array;
}
// Печатаем результат
void PrintArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}
int length = ReadData("Длина массива: ");
int numA = ReadData("Введите число минимального значения: ");
int numB = ReadData("Введите число максимального значения: ");
int[] array = Creatarr(length, numA, numB); //заполнение массива случайными числами
PrintArr(array); //вывод массива
