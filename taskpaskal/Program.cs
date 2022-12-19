Console.Clear();
Console.Write("Введите число: ");
int N=int.Parse(Console.ReadLine());
int[,] matrix = new int[N,N];
int i=1;
for(int k=0;k<N;k++) matrix[k,0]=1;
matrix[1,1]=1;
while(i<=N-1){
    int j=1;
    while(j<=i){
    matrix[i,j]=matrix[i-1,j-1]+matrix[i-1,j];
    j++;
    }
    i++;
}
for (int j = 0; j < matrix.GetLength(0); j++)
    {
        for (int k = 0; k < matrix.GetLength(1); k++)
        {
            Console.Write($"{matrix[j, k]} \t");
        }
        Console.WriteLine();
    }