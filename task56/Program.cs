//Задача № 56

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
    int[] summm = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           summm[i] += matrix[i, j];
            
        }
    
    }
    int r = summm[0];
    int e =0;
    for (int i = 0; i < summm.Length; i++)
    {
        if (summm[i] < r)
        {
            r = summm[i];
            e = i +1;
        }
    }
    Console.WriteLine(" минимальная сумма строки: " + e);
    Console.WriteLine(" минимальная сумма элементов равна: " + r);
}

Console.Write("Введите количество строк: ");
int stroki = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int stolb = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[stroki, stolb];
Console.WriteLine("матрица: ");
Massiv(matrix);


Sortirov(matrix);