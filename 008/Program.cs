// Показать таблицу квадратов чисел от 1 до N
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine() ?? "0");
int a = 1;

while (a<=N)
{
    int b=a*a;
    Console.WriteLine($"Квадрат числа {a}, равен {b} ");
    a++;
}