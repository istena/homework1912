//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
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
int[,] Matrix(int[,] matrix1,int[,] matrix2)
{ 
    int[,] res= new int[matrix1.GetLength(0),matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {  
        for (int j = 0; j < matrix2.GetLength(1); j++){
            res[i,j]=0;
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                res[i,j]+=matrix1[i,k]*matrix2[k,j];
            }
        }
        
    }
    return res;
}

Console.Clear();
Console.Write("Введите размер первой матрицы: ");
int[] coord1 = Console.ReadLine().Split(" ").Select(s => int.Parse(s)).ToArray();
int[,] matrix1 = new int[coord1[0], coord1[1]];
InputMatrix(matrix1);
Console.Write("Введите размер второй матрицы: ");
int[] coord2 = Console.ReadLine().Split(" ").Select(s => int.Parse(s)).ToArray();
int[,] matrix2 = new int[coord2[0], coord2[1]];
InputMatrix(matrix2);
if (matrix1.GetLength(1)==matrix2.GetLength(0)){
    int[,] res= new int[matrix1.GetLength(0),matrix2.GetLength(1)];
    res=Matrix(matrix1,matrix2);
    Console.WriteLine("Матрица произведения :");
    for (int i = 0; i <res.GetLength(0); i++)
        {
            for (int j = 0; j < res.GetLength(1); j++)
            {
                Console.Write($"{res[i, j]} \t");
            }
            Console.WriteLine();
        }
}
else Console.WriteLine("Матрицы умножить нельзя :");