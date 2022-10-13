// Дано число. Проверить кратно ли оно 7 и 23
Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine() ?? "0");
int b = 7;
int c = 23;

if (a % b == 0 && a % c == 0)
{
    Console.WriteLine("Данное число кратно 7 и 23");
}
else
{
    Console.WriteLine("Данное число не кратно 7 и 23");
}