// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).4 -> да; -3 -> нет; 7 -> нет;

Console.Clear();
Console.WriteLine("Веедите своё число");
int a = Convert.ToInt32(Console.ReadLine());

if (a % 2 == 0)
{
    Console.WriteLine("Ваше число чётное");
}
else
{
    Console.WriteLine("Ваше число не чётное");
}
Console.WriteLine("Спасибо за проверку ДЗ");