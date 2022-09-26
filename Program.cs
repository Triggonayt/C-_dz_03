
// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Clear();
Console.WriteLine("Enter a 5-digit number");
string n = Console.ReadLine();

if (n.Length < 5 | n.Length > 5)
{
    Console.WriteLine("This is not a 5-digit number");
}

if (n[0] == n[4] && n[1] == n[3])
{
    Console.WriteLine("palindrome");
}
else
{
    Console.WriteLine("No");
}
