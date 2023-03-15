/* Второе домашнее задание */

/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. */
Console.WriteLine("Введите трехзначное число: ");
int number =  Convert.ToInt32(Console.ReadLine());
string result = Convert.ToString(number);
Console.WriteLine(result[1]);

/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. */
Console.WriteLine("Введите число: ");
int number =  Convert.ToInt32(Console.ReadLine());
string result = Convert.ToString(number);
  if ( result.Length > 2)
    { Console.WriteLine(result[2]);
     }
  else { 
    Console.WriteLine( "Третьей цифры нет" ); 
    }

/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным. */

Console.Write("Введи цифру, обозначающую день недели: ");
int numberDay = Convert.ToInt32(Console.ReadLine());

void check (int numberDay) {
  if ( numberDay == 6 || numberDay == 7 ) {
  Console.WriteLine("Этот день выходной");
  }
  else if ( numberDay < 1 || numberDay > 7 ) {
    Console.WriteLine( "Это не число не дня недели" ) ;
  }
  else Console.WriteLine( "Это не выходной день недели" );
}
check(numberDay);