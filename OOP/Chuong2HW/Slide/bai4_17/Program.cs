int[,] A = new int[3, 4];

for (int i = 0; i < 3; i++) 
    for (int j = 0; j < 4; j++) 
{
    Console.Write("Nhap A[{0}, {1}] = ",i,j);
    A[i, j] = int.Parse(Console.ReadLine()) ;
}