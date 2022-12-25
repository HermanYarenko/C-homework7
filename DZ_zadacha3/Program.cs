/* Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */
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
void Result (int [,] arr)
{
    string res = "";
    double sum1 = 0;
    int size = arr.GetLength(0);
     for(int i=0; i<arr.GetLength(1);i++)
    {   sum1 = 0;
        for(int j=0; j<arr.GetLength(0); j++)
        {
           sum1 = (sum1 + arr[j,i]);
           
        }
        double sum = sum1/size;
        res = res + Math.Round(sum,1) + ";" + " ";
    }
    Console.WriteLine("Среднее арифметическое каждого столбца: "+ res);
}
int[,] array = GetArray(3,5,0,10);
PrintArray(array);
Console.WriteLine();
Result(array);
Console.WriteLine();