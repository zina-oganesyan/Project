// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Console.WriteLine("Введите количество строк");
int linesVol = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int columnsVol = Convert.ToInt32(Console.ReadLine());
double[,] numbers = new double[linesVol, columnsVol];
FillingArray(numbers);
PrintArray(numbers);

void FillingArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.WriteLine("Введите количество строк");
int linesVol = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int columnsVol = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[linesVol, columnsVol];
Console.WriteLine( "Посчитана средняя арифметическое элементов в каждом столбце: ");
FillingArray(numbers);
for (int j = 0; j < numbers.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        avarage = (avarage + numbers[i, j]);
    }
    avarage = avarage / linesVol;
    Console.Write(avarage + "; ");
}
Console.WriteLine();
PrintArray(numbers);

void FillingArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве, и возвращает позицию этого элемента или же указание, что такого элемента нет.
Console.WriteLine("Введите количество строк");
int linesVol = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int columnsVol = Convert.ToInt32(Console.ReadLine());
int [,] numbers = new int [10,10];
FillArrayRandomNumbers(numbers);

if (linesVol > numbers.GetLength(0) || columnsVol > numbers.GetLength(1))
{
    Console.WriteLine("Элемент не найден");
}
else
{
    Console.WriteLine($" В позици {linesVol} строки и {columnsVol} столбца находится элемент равный {numbers[linesVol-1,columnsVol-1]}");
}

PrintArray(numbers);

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(-100, 100)/10;
            }   
        }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }   
        Console.Write("]");
        Console.WriteLine(""); 
    }
}
