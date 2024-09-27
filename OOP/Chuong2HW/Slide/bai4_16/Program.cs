int[,] A = { { 1, 2, 3, 4 }
        , { 4, 3, 2, 1 }
        , { 1, 2, 3, 4 } };

for (int i = 0; i <A.GetLength(0); i++)
{
    for (int j = 0; j < A.GetLength(1); j++)
        Console.Write(A[i, j] + " ");
    Console.WriteLine();

}