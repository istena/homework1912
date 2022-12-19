//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
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
void sort(int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int count;
        do {
        count=0;
        for(int j = 0;j < matrix.GetLength(1)-1; j++){            
            if (matrix[i,j]<matrix[i,j+1]){
                int temp =matrix[i,j];
                matrix[i,j]=matrix[i,j+1];
                matrix[i,j+1]=temp;
                count++;
            }
        }
        }
        while (count>0);
    }
}
Console.Clear();
Console.Write("Введите размер матрицы: ");
int[] coord = Console.ReadLine().Split(" ").Select(s => int.Parse(s)).ToArray();
int[,] matrix = new int[coord[0], coord[1]];
InputMatrix(matrix);
sort(matrix);
Console.WriteLine();
 for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
