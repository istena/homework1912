//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементо
void InputMatrix(int[, ] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11); // [-10, 10]
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}
int minMatrix(int[, ] matrix)
{ 
    int minstroka=0,min=100000;
    for (int i = 0; i < matrix.GetLength(0); i++)
    { 
        int sum=0;
        for (int j = 0; j < matrix.GetLength(1); j++)sum+=matrix[i,j];
        if(sum<min) {
            min=sum;
            minstroka=i; 
        }
    }
    return minstroka;
}

Console.Clear();
Console.Write("Введите размер матрицы: ");
int[] coord = Console.ReadLine().Split(" ").Select(s => int.Parse(s)).ToArray();
int[,] matrix = new int[coord[0], coord[1]];
InputMatrix(matrix);
Console.Write($"строку c наименьшей суммой элементов: {minMatrix(matrix)} ");
