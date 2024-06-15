using System;

class Program
{
    static void Main()
    {
        // Задача 1: Вывод всех натуральных чисел в промежутке от M до N
        int M = 1; // начальное значение
        int N = 10; // конечное значение
        Console.WriteLine("Задача 1: Вывод всех натуральных чисел в промежутке от M до N");
        PrintNumbers(M, N);
        Console.WriteLine();

        // Задача 2: Вычисление функции Аккермана
        int m = 3;
        int n = 2;
        Console.WriteLine("Задача 2: Вычисление функции Аккермана");
        Console.WriteLine($"Ackermann({m}, {n}) = {Ackermann(m, n)}");
        Console.WriteLine();

        // Задача 3: Вывод элементов массива с конца
        int[] array = { 1, 2, 3, 4, 5 };
        Console.WriteLine("Задача 3: Вывод элементов массива с конца");
        PrintArrayReverse(array, array.Length - 1);
    }

    // Метод для задачи 1
    static void PrintNumbers(int M, int N)
    {
        if (M > N)
            return;
        Console.WriteLine(M);
        PrintNumbers(M + 1, N);
    }

    // Метод для задачи 2
    static int Ackermann(int m, int n)
    {
        if (m == 0)
            return n + 1;
        if (m > 0 && n == 0)
            return Ackermann(m - 1, 1);
        return Ackermann(m - 1, Ackermann(m, n - 1));
    }

    // Метод для задачи 3
    static void PrintArrayReverse(int[] array, int index)
    {
        if (index < 0)
            return;
        Console.WriteLine(array[index]);
        PrintArrayReverse(array, index - 1);
    }
}
