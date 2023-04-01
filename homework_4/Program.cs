
/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. */

Console.WriteLine("Введите число A: ");
int numberA = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число B: ");
int numberB = int.Parse(Console.ReadLine()!);
int result = numberA;
for(int i = 1 ; i < numberB; i++) {
  result = result * numberA;
}
Console.WriteLine("numberA в степени numberB равно: " + result);

/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. */

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int sumNumbers = 0;

while (number > 0)
{
int numb = number % 10;
number = number / 10;
sumNumbers = sumNumbers + sumNumbers;
}
Console.WriteLine("Сумма чисел: " + sumNumbers);

/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. */
