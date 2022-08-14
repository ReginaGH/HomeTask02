// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет (645 -> 5; 78 -> третьей цифры нет; 32679 -> 6).
Console.WriteLine("Напишите число ");
string s = Convert.ToString(Console.ReadLine());
int third = int.Parse(s[2].ToString());
if(s.Length>=3)
    Console.WriteLine(third);
else if(s.Length<=2)
    Console.WriteLine("Третьей цифры нет");