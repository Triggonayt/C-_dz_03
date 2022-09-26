

// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// Console.Clear();
// Console.WriteLine("Enter a 5-digit number");
// string n = Console.ReadLine();

// if (n.Length < 5 | n.Length > 5)
// {
//     Console.WriteLine("This is not a 5-digit number");
// }

// if (n[0] == n[4] && n[1] == n[3])
// {
//     Console.WriteLine("palindrome");
// }
// else
// {
//     Console.WriteLine("No");
// }



// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
Console.WriteLine("Enter the X coordinates of point A");
int a1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the Y coordinates of point A");
int a2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the Z coordinates of point A");
int a3 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Enter the X coordinates of point B");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the Y coordinates of point B");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the Z coordinates of point B");
int b3 = Convert.ToInt32(Console.ReadLine());

// √((x2-x1)^2 )+(y2-y1)^2+(z2-z1)^2

double ab = Math.Sqrt(Math.Pow((a1-b1), 2) + Math.Pow((a2-b2), 2) + Math.Pow((a3-b3), 2));

Console.WriteLine($" Distance between points = {ab}");

