// Задача №60


void Massiv(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = new Random().Next(-10, 11);
            Console.Write(matrix[i, j, k] + " \t");
            }
        }
        Console.WriteLine();
    }
}
void PrintM(int[,,] Matrix1)
{
        for (int i = 0; i < Matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < Matrix1.GetLength(1); j++)
        {
            for (int k = 0; k < Matrix1.GetLength(2); k++)
            {
                Console.WriteLine(Matrix1[i, j, k] + "(" + i + "," + j + "," + k + ")");
            }
        }
        Console.WriteLine();
    }
}

Console.Write("Введите координату по x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату по y: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату по z: ");
int z = Convert.ToInt32(Console.ReadLine());

int[,,] Matrix1 = new int[x, y, z];
Massiv(Matrix1);
PrintM(Matrix1);