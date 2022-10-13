// Даны два числа. Показать большее и меньшее число
int a = 15;
int b = 9;
int max = 0;
int min = 0;

if (a > b)
{
    max = a;
    min = b;
}
else
{
    max = b;
    min = a;
}
Console.WriteLine($"Mаксимальное число равно {max}, минимальное число равно {min}");