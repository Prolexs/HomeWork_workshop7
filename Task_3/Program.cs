//  Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.WriteLine("Задайте колл-во строк");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте колл-во столбцов");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] arr = new int[x, y];
Random rand = new Random();
//double average = 0;

FillArray(arr);

for (int j = 0; j < arr.GetLength(1); j++)
{
    double average = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        average = (average + arr[i, j]);
    }
    average = average / x;
    average = Math.Round(average, 1);
    Console.Write(average + ";     ");

}
Console.WriteLine();
PrintArray(arr);




void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rand.Next(1, 100);
        }
    }
}


void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "\t  ");
        }
        Console.WriteLine();
    }
}


