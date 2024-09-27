int[] A = { 5, 10, 15, 20, 25 };
int[] B = new int[5];

Array.Copy(A, B, 5);

Console.Write("Mang A: ");
foreach (int x in A)
Console.Write(x + " ");

Console.Write("Mang B: ");
foreach (int x in B)
Console.Write(x +" ");