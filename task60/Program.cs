// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
void InputMatrix(int[, , ] matrix)
{ 
    int s=10;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int z = 0; z < matrix.GetLength(2); z++){
                
                matrix[i,j,z]=s ;
                s++ ;
                Console.Write($"{matrix[i,j,z]}({i},{j},{z}) \t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
Console.Clear();
Console.Write("Введите размер матрицы: ");
int[] coord = Console.ReadLine().Split(" ").Select(s => int.Parse(s)).ToArray();
int[, ,] matrix = new int[coord[0], coord[1],coord[2]];
InputMatrix(matrix);

