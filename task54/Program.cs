//Задача № 54

void Massiv(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-10, 11);
            Console.Write(matrix[i, j] + " \t");
        }
        Console.WriteLine();
    }
}
void Sortirov(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1)-1; k++)
            {
                if (matrix[i, k] < matrix[ i, k + 1])
                {
                    int t = matrix[i, k + 1];
                    matrix[i, k + 1] = matrix[i, k];
                    matrix[i, k] = t;
                }
            }
            Console.Write(matrix[i, j] + " \t");
        }
    Console.WriteLine();
    }
}

Console.Write("Введите количество строк: ");
int stroki = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int stolb = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[stroki, stolb];
Console.WriteLine("матрица: ");
Massiv(matrix);
Console.WriteLine(" вывод результата матрицы: ");
Sortirov(matrix);