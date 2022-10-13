// Проверить пятизначное число на палиндром.
Console.WriteLine("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine() ?? "0");
int x5 = num % 10;
int x4 = num /10 % 10;
int x2 = num /1000%10;
int x1 = num / 10000;

if ((x5 == x1)&&(x4==x2))
{
    Console.WriteLine($"Число {num} является палиндромом");
}
else
{
    Console.WriteLine($"Число {num} не является палиндромом");
}