// Задача №41
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3



//Вводим данные
int ReadData(string msg)

{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}
//Записываем числа в массив
int[] InputArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = ReadData($"Введите {i + 1}-й элемент");
    }
    return array;
}
//Выводим массив
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"a[{i}] = {array[i]}");
    }
}
// Считаем кол-во чисел больше 0
int CountPositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

int length = ReadData("Введите количество элементов: ");
int[] array;
array = InputArray(length);
PrintArray(array);
Console.WriteLine($"Количество чисел больше 0 - {CountPositiveNumbers(array)}");