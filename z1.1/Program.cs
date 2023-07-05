//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

double [,] NewDoubleRandArray(int rows, int columns)

{
    double [,] array = new double [rows, columns];
    Random random = new Random();
    for (int i = 0; i < rows;i++)
    {
        for (int j = 0; j < columns;j++)   
        {
            array[i,j] = Math.Round((random.NextDouble() * 10),2);
            
        }
    
    }
    return array;
}

void PrintArray(double [,] arr)
{
    for(int i = 0; i<arr.GetLength(0); i++)
    {
        for (int j=0; j<arr.GetLength(1); j++)
        {
            Console.Write($"[{arr[i,j]}]  ");
        }
        Console.WriteLine("");
    }
}

double [,] array = NewDoubleRandArray(5,5);
PrintArray(array);
