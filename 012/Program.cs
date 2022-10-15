// Найти количество заданного числа в массив (полный разбор на семинаре)
// Составляем псевдокод
//int size = 8;
//int n = 3;
//int array = [1, 2, 3, 4, 5, 3, 6, 9];
//index = 0;
//count = 0;
//
//while (index < size)
//    if (array[index] == n)
//       count++;
//    index++;
//
//print(count);

// Переписываем на С#

// Console.WriteLine();
// Console.Write("Введите размер массива: ");
// int size = int.Parse(Console.ReadLine() ?? "0");
// Console.WriteLine();
// int [] array = new int [size];
// int index = 0;
// int count = 0;
//
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine() ?? "0");
// Console.WriteLine();
//
// while (index < size)
// {
//    array[index] = new Random().Next(0, 10);
//    index++;
// }
// Console.WriteLine("Ваш массив ");
// index = 0;
//
// while(index < size)
// {
//     Console.Write($"{array[index]} ");
//     index++;
// }     
// index = 0;
//
// while (index < size)
// {
//    if (array[index] == n)
//        count++;
//    index++;    
// }
// Console.WriteLine();
// Console.WriteLine();
// Console.WriteLine($"Число {n} встречается {count} раз");
// Console.WriteLine();



// Начинаем улучшать

// Console.WriteLine();
// Console.Write("Введите размер массива: ");
// int size = int.Parse(Console.ReadLine() ?? "0");
// Console.WriteLine();
// int [] array = new int [size];                              
// int count = 0;

// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine() ?? "0");
// Console.WriteLine();

// for(int index = 0; index < size; index++)

//    array[index] = new Random().Next(0, 10);
    
// Console.WriteLine("Ваш массив ");


// for(int index = 0; index < size; index++)

//      Console.Write($"{array[index]} ");
     
     
// for(int index = 0; index < size; index++)

//     if (array[index] == n)
//         count++;
        
// Console.WriteLine();
// Console.WriteLine();
// Console.WriteLine($"Число {n} встречается {count} раз");
// Console.WriteLine();

// Переходим к функциям

void PrintArray(int [] array)
{
    for(int index = 0; index < array.Length; index++)

     Console.Write($"{array[index]} ");
}
                                                       // это две универсальные функции
void FillArray(int [] array, int min, int max)
{
    for(int index = 0; index < array.Length; index++)
    array[index] = new Random().Next(min, max);
}

int Count (int[]array, int value)
{
    int count = 0;
    for(int index = 0; index < array.Length; index++)
        if (array[index] == value)
        count++;
    return count;    
}

Console.WriteLine();
Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine();
int [] array = new int [size];                              

Console.Write("Введите число: ");
int value = int.Parse(Console.ReadLine() ?? "0");
int count = Count(array, value);
Console.WriteLine();

FillArray(array, 0, 15);
Console.WriteLine("Ваш массив ");

PrintArray(array);                                              

Console.WriteLine();
Console.WriteLine();
Console.WriteLine($"Число {value} встречается {count} раз");
Console.WriteLine();
