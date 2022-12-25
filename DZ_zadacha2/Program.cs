/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

int[,] GetArray (int m, int n, int minValue, int maxValue)
{
    int[,] result = new int [m,n];
    for(int i=0; i<m;i++)
    {
        for(int j=0; j<n; j++)
        {
            result[i,j] = new Random().Next(minValue,maxValue);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for(int i=0; i<inArray.GetLength(0);i++)
    {
        for(int j=0; j<inArray.GetLength(1); j++)
        {
           Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
}

void Res (int [,] arr)
{
Console.Write("Введите номер строки: ");
int i = int.Parse(Console.ReadLine()!);
Console.Write("Введите номер столбца: ");
int j = int.Parse(Console.ReadLine()!);
 if (i<=arr.GetLength(0)&& j<=arr.GetLength(1)) Console.WriteLine($"Элемент массива [{i},{j}] = {arr[i-1,j-1]}");
 else { Console.WriteLine();
        Console.WriteLine("Такого элемента в массиве нет");}
}
int[,] array = GetArray(3,4,0,10);
PrintArray(array);
Console.WriteLine();
Res(array);
