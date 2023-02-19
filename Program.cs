/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да*/

 Console.WriteLine("Введите число : ");
 string number = Console.ReadLine();
 int len = number.Length;

 if(len == 5)
 {
     if(number[0] == number[4] && number[1] == number[3])
    {
         Console.WriteLine($"{number}  является полиндромом");
     }

     else
     {
         Console.WriteLine($"{number} не является полиндромом");
     }
 }
 else
 {
     Console.WriteLine($"Что то пошло не так, {number} не является пятизначным числом");
 }


/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53*/


int x1 = ReadInt("Введите координату X первой точки: ");
int y1 = ReadInt("Введите координату Y первой точки: ");
int z1 = ReadInt("Введите координату Z первой точки: ");
int x2 = ReadInt("Введите координату X второй точки: ");
int y2 = ReadInt("Введите координату Y второй точки: ");
int z2 = ReadInt("Введите координату Z второй точки: ");

int A = x2 - x1;
int B = y2 - y1;
int C = z1 - z2;

if(A == 0 && B ==0 && C ==0)
{
    Console.WriteLine("Попадание на ось ");
}

double length = Math.Sqrt(A * A + B * B + C * C);
Console.WriteLine(Math.Round(length,2));


int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int number = ReadInt("Введите число N: ");

for (int i = 1; i <= number; i++)
{ 
    Console.Write($"{i*i*i} ");
}


int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}