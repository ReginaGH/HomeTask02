// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трехзачное число");
string s = Convert.ToString(Console.ReadLine());
int second = int.Parse(s[s.Length-2].ToString());
Console.WriteLine(second);