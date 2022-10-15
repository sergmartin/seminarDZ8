// Задача №62


void Massiv(int[,] matrix)
{
    int t = 1, i = 0, j = 0;
    while (t <= matrix.GetLength(0) * matrix.GetLength(1))
    {
        matrix[i, j] = t;
        t++;
        if (i <= j + 1 && i + j < matrix.GetLength(1) - 1) j++;
        else if (i < j && i + j >= matrix.GetLength(0) - 1) i++;
        else if (i >= j && i + j > matrix.GetLength(1) - 1) j--;
        else i--;

    }
    for (i = 0; i < matrix.GetLength(0); i++)
    {
        for (j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " \t");
        }
        Console.WriteLine();
    }
}


Console.Write("Введите координату по x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату по y: ");
int y = Convert.ToInt32(Console.ReadLine());


int[,] Matrix1 = new int[x, y];
Massiv(Matrix1);
