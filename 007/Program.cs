// Найти третью цифру с начала числа и с конца числа или сообщить, что её нет.
Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine() ?? "0");

if (num < 100)
{
    Console.WriteLine("Третьей цифры нет!");
}

else
{
    int digit = num / 100 % 10;
    Console.WriteLine($"Третья цифра с конца числа {digit}");
    {
    while (num > 1000)

    num /= 10;
    Console.WriteLine($"Третья цифра с начала числа {num % 10}");
    }
}
    

