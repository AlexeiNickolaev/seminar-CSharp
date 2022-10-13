// Определить количество цифр в числе
Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine() ?? "0");
int count = 0;

if (num == 0)
{
    Console.WriteLine("Количество цифр в числе равно 1");
}
else
{
    while (num > 0)
    {
        num = num / 10;
        count++;
    }
    Console.WriteLine($"Количество цифр в числе равно {count}");
}


