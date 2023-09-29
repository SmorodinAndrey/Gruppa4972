// // Вывод сообщения и запись введённых данных
// int Prompt(string message)
// {
//     Console.Write(message);
//     string value = Console.ReadLine() ?? ",";
//     int number = Convert.ToInt32(value);

//     return number;
// }

// string DecToBin(int num)
// {
//     string line = "";
//     while (num > 0)
//     {
//         line = num % 2 + line;
//         num = num / 2;
//     }
//     return line;
// }

// // Переводит число в двоичное
// string DecToBinRec(int number)
// {
//     return number == 0 ? "" : DecToBinRec(number / 2) + Convert.ToString(number % 2);
// }

// //String bin = Convert.ToString(a, 2);
// //String bin = Convert.ToString(int.Parse(Console.ReadLine()??"0"), 2);

// int number = Prompt("Введите число: ");

// Console.Write($"Двоичное представление числа(Simpl): {DecToBin(number)}");
// Console.WriteLine();
// Console.Write($"Двоичное представление числа(Recurent): {DecToBinRec(number)}");
// Console.WriteLine();
// Console.WriteLine(Convert.ToString(number, 2));
// Console.WriteLine(Convert.ToString(number, 8));
// Console.WriteLine(Convert.ToString(number, 16));

// Задача №42
// Напишите программу, которая будет
// преобразовывать десятичное число в двоичное.
// Например:
// 45 -> 101101
// 3 -> 11
// 2 -> 10



// String bin = Convert.ToString(a, 2);
// String bin = Convert.ToString(int.Parse(Console.ReadLine()??"0"),2);



// // Вывод сообщения и запись введённых данных
// int Prompt(string message)
// {
//     Console.Write(message);
//     string value = Console.ReadLine()??",";
//     int number = Convert.ToInt32(value);

//     return number;
// }

// string DecToBin(int num)
// {
//     string line ="";
//     while(num>0)
//     {
//         line = num%2+line;
//         num=num/2;
//     }
//     return line;
// }

// // Переводит число в двоичное
// string DecToBinRec(int number)
// {
//     return number == 0 ? "" : DecToBinRec(number / 2) + Convert.ToString(number % 2);
// }

// //String bin = Convert.ToString(a, 2);
// //String bin = Convert.ToString(int.Parse(Console.ReadLine()??"0"), 2);

// int number = Prompt("Введите число: ");

// Console.Write($"Двоичное представление числа(Simpl): {DecToBin(number)}");
// Console.WriteLine();
// Console.Write($"Двоичное представление числа(Recurent): {DecToBinRec(number)}");
// Console.WriteLine();
// Console.WriteLine( Convert.ToString(number, 2));
// Console.WriteLine( Convert.ToString(number, 8));
// Console.WriteLine( Convert.ToString(number, 16));


// Задача №42
// Напишите программу, которая будет
// преобразовывать десятичное число в двоичное.
// Например:
// 45 -> 101101
// 3 -> 11
// 2 -> 10



// String bin = Convert.ToString(a, 2);
// String bin = Convert.ToString(int.Parse(Console.ReadLine()??"0"),2);



// // Вывод сообщения и запись введённых данных
// int Prompt(string message)
// {
//     Console.Write(message);
//     string value = Console.ReadLine()??",";
//     int number = Convert.ToInt32(value);

//     return number;
// }

// string DecToBin(int num)
// {
//     string line ="";
//     while(num>0)
//     {
//         line = num%2+line;
//         num=num/2;
//     }
//     return line;
// }

// // Переводит число в двоичное
// string DecToBinRec(int number)
// {
//     return number == 0 ? "" : DecToBinRec(number / 2) + Convert.ToString(number % 2);
// }

// //String bin = Convert.ToString(a, 2);
// //String bin = Convert.ToString(int.Parse(Console.ReadLine()??"0"), 2);

// int number = Prompt("Введите число: ");

// Console.Write($"Двоичное представление числа(Simpl): {DecToBin(number)}");
// Console.WriteLine();
// Console.Write($"Двоичное представление числа(Recurent): {DecToBinRec(number)}");
// Console.WriteLine();
// Console.WriteLine( Convert.ToString(number, 2));
// Console.WriteLine( Convert.ToString(number, 8));
// Console.WriteLine( Convert.ToString(number, 16));



//Вводим данные
int ReadData(string msg)

{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

//Печатаем результат
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

String DecToBin(int num)
{
    string line = String.Empty; //string line ="";
    while (num > 0)
    {
        line = num % 2 + line;
        num /= 2; //num = num / 2;
    }
    return line;
}

int num = ReadData("Введите  число");

string line = DecToBin(num);

PrintResult($"Число: {num} в двоичной системе: {line}");