// Задача 5
// Напишите программу, которая на вход принимает одно число (N),
// а на выходе показывает все целые числа в промежутке от -N до N.

// int numN = int.Parse(Console.ReadLine()?? "0");
// int evNumN = (-1) * numN;
// while(evNumN < numN)
// {
//     Console.Write(evNumN+",");
//     evNumN=evNumN+1; // evNumN+=1; или evNumN++;
// }
// Console.WriteLine(numN);

// int numN = int.Parse(Console.ReadLine()?? "0");
// if (numN < 0) numN = -numN;
// for(int evNumN = -numN; evNumN <= numN; evNumN++){
//     Console.Write(evNumN);
//     Console.Write(" ");
// }

// int N = int.Parse(Console.ReadLine()?? "0");
// int minusN = -N;
// for(int i = -N; i <= N; i++)
// {
//     Console.Write(i.ToString()+ " ");
// }

int numN = int.Parse(Console.ReadLine() ?? "0");
int evNumN = (-1) * numN;
while (evNumN < numN)
{
    Console.Write(evNumN + ",");
    evNumN++;
}
Console.WriteLine(numN);