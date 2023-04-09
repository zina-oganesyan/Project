//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
int numberN = InputNumbers("Введите N: ");
int count = 2;
PrintNumber(numberN, count);
Console.Write(1);
void PrintNumber(int numberN, int count)
{
    if (count > numberN) return;
    PrintNumber(numberN, count + 1);
    Console.Write(count + ", ");
}
int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.WriteLine("Введите начальное число M:");
int numberM = int.Parse(Console.ReadLine());
Console.WriteLine("Введите начальное число N:");
int numberN = int.Parse(Console.ReadLine());
void numberSum (int numberM, int numberN, int sum)
{
    if (numberM > numberN) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
        return;
    }
    sum = sum + (numberM++);
    numberSum(numberM, numberN, sum);
}
numberSum(numberM, numberN, 0);

// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
int numberM = InputNumbers("Введите M: ");
int numberN = InputNumbers("Введите N: ");
int functionAkk = Ack(numberM, numberN);
Console.Write($"Функция Аккермана = {functionAkk} ");
int Ack(int numberM, int numberN)
{
    if (numberM == 0) return numberN + 1;
    else if (numberM == 0) return Ack(numberM - 1, 1);
    else return Ack(numberM - 1, Ack(numberM, numberN - 1));
}

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}
