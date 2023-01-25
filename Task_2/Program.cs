//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.WriteLine("Задайте колл-во строк");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте колл-во столбцов");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] arr = new int[x, y];
Random rand = new Random();


for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
        arr[i, j] = rand.Next(1, 100);
}

for (int i = 0; i < arr.GetLength(0); i++) 
{
    for (int j = 0; j < arr.GetLength(1); j++)
        Console.Write(arr[i,j] + "\t  ");
        Console.WriteLine();
}


Console.WriteLine("Введите номер столбца, нумерация начинается с нуля");
int fy = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер строки, нумерация начинается с нуля");
int fx = Convert.ToInt32(Console.ReadLine());
if (fx > x && fy > y)
    Console.WriteLine("Введеная вами позиция за пределами размера массива, попробуйте снова");
else
{
    object search = arr.GetValue(fx, fy);
    Console.WriteLine($" По вашему запросу найдена позиция со значением {search} ");
}