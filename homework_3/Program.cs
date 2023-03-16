/* Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя. */

Console.WriteLine("Введите пятизначное число:");
int number = int.Parse(Console.ReadLine()!);
palindromicNumber(number);

void palindromicNumber(int number)
{
    if(number >= 10000)
    {
        int division1 = number / 10000;
        int remainder1 = number % 10;
 
            if(division1 == remainder1)
            {
                number = number / 10;
                int division2 = (number / 100) % 10;
                int remainder2 = number % 10;
                if(division2 == remainder2)
                    Console.WriteLine("Число является палиндромом");
            }
            else {
            Console.WriteLine ("Число не является палиндромом");
            }
 
    }

}

/* Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.*/

Console.WriteLine("Введите координату x точки 1");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y точки 1");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z точки 1");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату x точки 2");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y точки 2");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z точки 2");
int z2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(DistancePount(x1, y1, x2, y2, z1, z2));

double DistancePount(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double result1 = (x2 - x1)*(x2 - x1);
    double result2 = (y2 - y1)*(y2 - y1);
    double result3 = (z2 - z1)*(z2 - z1);

    double result = Math.Sqrt(result1 + result2 + result3);
    return result;
} 


/* Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.*/
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
Cube(number);


void Cube ( int number)
{
   for ( int i = 1; i <= number;  i++)
    {
      Console.Write($"{i * i * i}, ");
      }
}


