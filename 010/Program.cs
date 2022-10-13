// Возведите число А в натуральную степень B используя цикл.
Console.Write("Введите число А: ");
int A = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число B: ");
int B = int.Parse(Console.ReadLine() ?? "0");
int C = 1;
int count = 0;
while (count < B)
{
    C = C * A;
    count++;
}
Console.WriteLine($"Число {A} в степени {B} равно {C}");