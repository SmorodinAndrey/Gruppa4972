//  Задача №43
//  Напишите программу, которая найдёт точку пересечения двух прямых,
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//  b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)



const int Coefficient = 0;
const int Constant = 1;
const int X = 0;
const int Y = 0;
const int Line1 = 1;
const int Line2 = 2;

double[] lineData1 = InputLineData(Line1);
double[] lineData2 = InputLineData(Line2);

if (ValidateLines(lineData1, lineData2))
{
    double[] coord = FindCoords(lineData1, lineData2);
    Console.Write($"Точка пересечения уравнений y={lineData1[Coefficient]}*x+{lineData1[Constant]} и y={lineData2[Coefficient]}*x+{lineData2[Constant]}");
    Console.WriteLine($"Имеет координаты ({coord[X]},{coord[Y]})");
}

//Вводим данные
double ReadData(string msg)

{
    Console.WriteLine(msg); //вывести сообщение
    string value = (Console.ReadLine() ?? "0"); //считывает с консоли строку
    double result = Convert.ToDouble(value); //преобразует строку в целое число
    return result; // возвращает результат
}

//Ввод данных по прямой
double[] InputLineData(int numberOfLine)
{
    double[] lineData = new double[2];
    lineData[Coefficient] = ReadData($"Введите коэффициент для {numberOfLine}прямой: ");
    lineData[Constant] = ReadData($"Введите константу для {numberOfLine}прямой: ");
    return lineData;
}
//Поиск координат
double[] FindCoords(double[] lineData1, double[] lineData2)
{
    double[] coord = new double[2];
    coord[X] = (lineData1[Constant] - lineData2[Constant]) / (lineData2[Coefficient] - lineData1[Coefficient]);
    coord[Y] = (lineData1[Constant] * coord[X] + lineData1[Constant]);
    return coord;
}

bool ValidateLines(double[] lineData1, double[] lineData2)
{
    if (lineData1[Coefficient] == lineData2[Coefficient])
    {
        if (lineData1[Constant] == lineData2[Constant])
        {
            Console.WriteLine("Прямые совпадают");
            return false;
        }
        else
        {
            Console.WriteLine("Прямые параллельны");
            return false;
        }
    }
    return true;
}