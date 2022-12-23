Console.Clear();

Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1000 && number > 99)
{
    int number2 = ((number % 100) / 10);
    Console.WriteLine("Вторая цифра вашего числа");
    Console.WriteLine(number2);
}
else
{
    Console.WriteLine("Вы ввеели не трехзначное значное число ало");
}