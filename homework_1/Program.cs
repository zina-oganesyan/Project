/* Первое домашнее задание */

/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее. */
Console.WriteLine("Введите несколько чисел, для определения большего числа, среди введеных чисел");
Console.WriteLine("Введите первое число: ");
int numberA =  Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberB =  Convert.ToInt32(Console.ReadLine());
if( numberA < numberB )
{
  Console.WriteLine( "Большее число: " + numberB );
}
else 
{
  Console.WriteLine ("Большее число: " + numberA );
}

/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел. */
Console.WriteLine("Введите три чисела, для определения большего числа, среди введеных чисел");
Console.WriteLine("Введите первое число: ");
int numberA =  Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberB =  Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int numberC =  Convert.ToInt32(Console.ReadLine());
if ( numberA > numberB && numberA > numberC )
  {
    Console.WriteLine( "Большее число: " + numberA );
  }
  else if ( numberB > numberA && numberB > numberC )
  {
    Console.WriteLine( "Большее число: " + numberB );
  } else {
    Console.WriteLine( "Большее число: " + numberC );
  }

/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка). */
Console.WriteLine("Введите число, для определения четное оно ли нет");
int number =  Convert.ToInt32(Console.ReadLine());
int remDiv = number % 2;

if( remDiv == 0 )
{
    Console.WriteLine( "Да, число четное" );
}
else
{
    Console.WriteLine( "Нет, число нечетное" );
}

/* Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N. */
Console.WriteLine("Введите число, для определения всех чётных числачисел от 1 до введенного числа");
int number =  Convert.ToInt32(Console.ReadLine());
int divNumber = 2;

if(number > 1)
{
    while(divNumber <= number)
    {
        Console.Write(divNumber + " ");
        divNumber = divNumber + 2;
    }
}
else {
          Console.Write( "Введенное число не содержит четных чисел" );
 }



/* Задача 7 HARD по желанию - идет за 2 необязательных Напишите программу, которая принимает на вход целое число любой разрядности и на выходе показывает вторую цифру слева этого числа или говорит, что такой цифры нет. Через строку решать нельзя. */





















