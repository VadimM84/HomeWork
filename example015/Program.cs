// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Clear();
Console.Write("Введи число и я подскажу вам выходной сегодня или нет: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 1 || num > 7)
{
  Console.WriteLine("Такого дня недели не существует");
}
else if (num == 6 || num == 7)
{
  Console.WriteLine("Да,сегодня выходной");
}
else
{
  Console.WriteLine("Нет, рабочая неделя продолжаеться");
}