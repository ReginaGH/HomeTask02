// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет (645 -> 5; 78 -> третьей цифры нет; 32679 -> 6).
Console.WriteLine("Напишите число ");
int n = Convert.ToInt32(Console.ReadLine());
if(99<n && n<1000)
{
    int digit3 = n%10;
    Console.WriteLine($"Третья цифра числа: {digit3}");
}
else if(999<n && n<10000)
{
    int digitb1000=n/100;
    int digitb10=n%10;
    int digitb100=(n-digitb1000*100 - digitb10)/10;
    Console.WriteLine($"Третья цифра числа: {digitb100}");
}
else if(9999<n && n<100000)
{
    int digit11000=n/1000;
    int digit11=n%100;
    int digit100=(n-digit11000*1000-digit11)/100;
    Console.WriteLine($"Третья цифра числа: {digit100}");
}
else if(n>0 && n<100)
{
    Console.WriteLine("Нет третьей цифры");   
}