// Найти сумму чисел от 1 до А
Console.Write("Введите число A: ");
int A = int.Parse(Console.ReadLine() ?? "0");
int i = 1;
int sum = 0;

while (i <= A)
{
    sum = sum + i;
    i++;
}
Console.WriteLine($"Сумма всех чисел равна {sum}");