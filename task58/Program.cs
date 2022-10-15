// задача 58


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
void Umnozh(int[,] Matrix1, int[,] Matrix2)
{
    int[,] RezMatr = new int[Matrix1.GetLength(0), Matrix1.GetLength(1)];
    for (int i = 0; i < Matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < Matrix1.GetLength(1); j++)
        {
            RezMatr[i, j] = Matrix1[i, j] * Matrix2[i, j];
            Console.Write(RezMatr[i, j] + " \t");
        }
        Console.WriteLine();
    }
    
}

Console.Write("Введите количество строк: ");
int stroki = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int stolb = Convert.ToInt32(Console.ReadLine());

int[,] Matrix1 = new int[stroki, stolb];
int[,] Matrix2 = new int[stroki, stolb];

Console.WriteLine("матрица первая: ");
Massiv(Matrix1);
Console.WriteLine("матрица первая: ");
Massiv(Matrix2);
Console.WriteLine("произведение матриц: ");
Umnozh(Matrix1,Matrix2);