// Вывести квадрат числа
Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine() ?? "0");
int b = a * a;

Console.WriteLine($"{a} в квадрате равно {b}");