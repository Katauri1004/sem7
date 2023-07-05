//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int [,] NewRandArray(int rows, int columns)

{
    int [,] array = new int [rows, columns];
    Random random = new Random();
    for (int i = 0; i < rows;i++)
    {
        for (int j = 0; j < columns;j++)   
        {
            array[i,j] = random.Next(1,9);
            
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

void GetAvarageCol(int [,] arr)
{
    double sum = 0;
    double colavarage = 0;
    int col = 0;

while(col<arr.GetLength(0))
  {

    for(int i = 0; i<arr.GetLength(1); i++)
    {

        sum=sum+arr[i,col];
    
    }
    colavarage = sum/arr.GetLength(0);
    Console.WriteLine($"Среднее арифметическое столбца {col+1} = {colavarage}");
    col++;
    sum=0;
    colavarage=0;
  }
}
int [,] array = NewRandArray(4,4);
PrintArray(array);
Console.WriteLine("");
GetAvarageCol(array);


