// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
void InputMatrix(int[, ] matrix)
{
    int count =0,i=0,j=0,size=0;
    while (count<(matrix.GetLength(0)*matrix.GetLength(1))){
        while(j<matrix.GetLength(1)-size){
            matrix[i,j]=count;
            count++;
            j++;
        }
        j--;
        while(i<(matrix.GetLength(0)-1-size)){
            i++;
            matrix[i,j]=count;
            count++; 
        }
        while(j>=1+size){
            j--;
            matrix[i,j]=count;
            count++; 
        }
        while(i>=2+size){
            i--;
            matrix[i,j]=count;
            count++; 
        }
        size++;
    }
    if (matrix.GetLength(0)*matrix.GetLength(1)%2==1){
        j++;
        matrix[i,j]=count;
    }
   
}
Console.Clear();
Console.Write("Введите размер матрицы: ");
int[] coord = Console.ReadLine().Split(" ").Select(s => int.Parse(s)).ToArray();
int[,] matrix = new int[coord[0], coord[1]];
InputMatrix(matrix);
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i, j]} \t");
    }
        Console.WriteLine();
}
