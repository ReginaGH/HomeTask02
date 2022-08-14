// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трехзачное число");
int number = Convert.ToInt32(Console.ReadLine());
int digit1 = number/100;
int digit2= number%10;
if(number<0)
{
    int digit3=(number*(-1)-(digit1*(-100)+digit2*(-1)))/10;
    Console.WriteLine($"Вторая цифра числа: {digit3}");
}
else
{
    int digit3=(number-(digit1*100+digit2))/10;
    Console.WriteLine($"Вторая цифра числа: {digit3}");
}