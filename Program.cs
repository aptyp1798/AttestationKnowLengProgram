// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

// void DigitsBetween(int m, int n)
// {
//     if(n >= m)
//     {
//         DigitsBetween(m, n-1);
//         Console.Write(n + " ");
//     }
// }

// DigitsBetween(5, 10);

// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// int Ackerman(int m, int n)
// {
//     if (m == 0)
//         return n + 1;
//     else 
//     if (n == 0)
//         return Ackerman(m - 1, 1);
//         return Ackerman(m - 1, Ackerman(m, n - 1));
// }

// Console.Write(Ackerman(2,3));

// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

int[] CreateArray(int size)
{
    Random random = new Random();
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(1, 100);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void PrintReverseArray(int[] array, int i = 0)
{
    if(i < array.Length)
    {
        PrintReverseArray(array, i + 1);
        Console.Write(array[i] + " ");
    }

}

int size = 4;
int[] array = CreateArray(size);
PrintArray(array);
PrintReverseArray(array);