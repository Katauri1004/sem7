//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.


int [,] NewRandArray(int rows, int columns)

{
    int [,] array = new int [rows, columns];
    Random random = new Random();
    for (int i = 0; i < rows;i++)
    {
        for (int j = 0; j < columns;j++)   
        {
            array[i,j] = random.Next(1,100);
            
        }
    
    }
    return array;
}

void PrintArray(int [,] arr)
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


Console.WriteLine("Ваш массив :");
int [,] array = NewRandArray(5,6);
PrintArray(array);

Console.WriteLine("Введите позицию строки");
int a = int.Parse(Console.ReadLine()); 
Console.WriteLine("Введите позицию столбца");
int b = int.Parse(Console.ReadLine()); 

if (a>array.GetLength(0)|| b>array.GetLength(1))
{
    Console.WriteLine("Такого элемента не существует в массиве");
    Environment.Exit(0);   
}
else
{
    Console.WriteLine($"Значение элемента массива = {array[a-1,b-1]} ");
}
