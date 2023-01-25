// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

//double[,] arr = new double[4, 7];
Random rand = new Random();
void PrintArray(double[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++) 
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine();
    }
}
void FillArray(double[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rand.Next(-50,50);
        }
    }
    
}


double[,] arr2d = new double[4, 7];
PrintArray(arr2d);
FillArray(arr2d);
Console.WriteLine();
PrintArray(arr2d);