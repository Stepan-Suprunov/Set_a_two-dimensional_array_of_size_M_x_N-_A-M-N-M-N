// Задать двумерный массив размера M x N , каждый элемент в массиве находится по формуле: A[M,N] = M + N. Вывести полученный массив на экран


int M = 3, N = 4;
int[,] array = new int[M,N];

for (int i = 0; i < array.GetLength(0); i++)
{

    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = i+j;
        Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
}