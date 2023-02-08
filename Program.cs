int programm, num;
Boolean begin = true;
 
while (begin)
{
Console.WriteLine("------");
Console.WriteLine("Введите число для соответствующей задачи или иное для выхода:");
Console.WriteLine("1. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");
Console.WriteLine("2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");
Console.WriteLine("3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.");
programm = Convert.ToInt32(Console.ReadLine());
 
switch (programm)
{
case 1:
// 1. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
 
Console.WriteLine("Введите число: ");
string number1 = Console.ReadLine();
int len = number1.Length;
 
if (len == 5)
{
if (number1[0] == number1[4] && number1[1] == number1[3])
{
Console.WriteLine($"{number1} - Палиндром");
}
else
{
Console.WriteLine($"{number1} - НЕ палиндром");
}
}
else
{
Console.WriteLine($"ОШИБКА: {number1} - не является пятизначным");
}

break;

case 2:
//2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве."
int x1 = ReadInt("Введите координату X первой точки: ");
int y1 = ReadInt("Введите координату Y первой точки: ");
int z1 = ReadInt("Введите координату Z первой точки: ");
int x2 = ReadInt("Введите координату X второй точки: ");
int y2 = ReadInt("Введите координату Y второй точки: ");
int z2 = ReadInt("Введите координату Z второй точки: ");
 
int A = x2 - x1;
int B = y2 - y1;
int C = z1 - z2;
 
double length = Math.Sqrt(A * A + B * B + C * C);
Console.WriteLine($"Длинна отрезка {length}");
 
 

int ReadInt(string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}
break;

//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N
case 3:
int number = ReadInt("Введите число N: ");
 
for (int i = 1; i <= number; i++)
{
Console.Write($"{i*i*i} ");
}
 
 
 

int ReadInt1(string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}

break;

default:
begin = false;
break;
}
}