// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным (6 -> да; 7 -> да; 1 -> нет)
Console.WriteLine("Напишите число, соответствующее дню недели");
int n = Convert.ToInt32(Console.ReadLine());
switch(n)
{
    case 1:
        Console.WriteLine("Не является выходным днём");
        break;
    case 2:
        Console.WriteLine("Не является выходным днём");
        break;
    case 3:
        Console.WriteLine("Не является выходным днём");
        break;
    case 4:
        Console.WriteLine("Не является выходным днём");
        break;
    case 5:
        Console.WriteLine("Не является выходным днём");
        break;
    case 6:
        Console.WriteLine("Ура! Выходной!");
        break;
    case 7:
        Console.WriteLine("Ура! Выходной!");
        break;
    default:
        Console.WriteLine("Нет такого дня недели");
        break;
}
