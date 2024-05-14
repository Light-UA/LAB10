using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Шевченко Олексій");

        // Генеруємо квадратну матрицю 10x10 з випадковими числами в діапазоні [-10, 25]
        int[,] matrix = GenerateMatrix();

        // Виводимо згенеровану матрицю на екран
        Console.WriteLine("Згенерована матриця:");
        PrintMatrix(matrix);
        Console.WriteLine();

        // Знаходимо та виводимо кількість елементів у стовпцях, що задовільняють умові 0 ≤ хij < 10
        Console.WriteLine("Кількість елементів у стовпцях, що задовільняють умові 0 ≤ хij < 10:");
        for (int j = 0; j < 10; j++)
        {
            int count = CountElementsInColumn(matrix, j);
            Console.WriteLine($"Стовпець {j+1}: {count}");
        }

        // Очікуємо натискання клавіші перед завершенням програми
        Console.ReadKey();
    }

    // Метод для генерації квадратної матриці 10x10 з випадковими числами в діапазоні [-10, 25]
    static int[,] GenerateMatrix()
    {
        Random random = new Random();
        int[,] matrix = new int[10, 10];
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                matrix[i, j] = random.Next(-10, 26); // Включно з -10, виключно 26
            }
        }
        return matrix;
    }

    // Метод для виведення матриці на екран
    static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    // Метод для знаходження кількості елементів у стовпці, які задовільняють умові 0 ≤ хij < 10
    static int CountElementsInColumn(int[,] matrix, int columnIndex)
    {
        int count = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            if (matrix[i, columnIndex] >= 0 && matrix[i, columnIndex] < 10)
            {
                count++;
            }
        }
        return count;
    }
}
