//   Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//   и возвращает значение этого элемента или же указание, что такого элемента нет.

//  Например, задан массив:

//  1 4 7 2

//  5 9 2 3

//  8 4 2 4

//  1 7 -> такого числа в массиве нет

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GetMatrix(int rowsCount, int columnsCount, int leftRange = -10, int rightRange = 10)
{
    int[,] matrix = new int[rowsCount, columnsCount];

    Random rand = new Random();

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rand.Next(leftRange, rightRange + 1);
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
}


void FindElements(int[,] matrix, int x , int y)
{
   if(x >= matrix.GetLength(0)   | y >= matrix.GetLength(1) )
    {
     Console.WriteLine("Tакого числа в массиве нет");
     return;
    }
   if(x < 0 | y < 0)
   {
     Console.WriteLine("Индекс числа не может быть меньше ноля");
      return;
   }
    
    

   Console.WriteLine($"Значение элемента, соответствующего данным индексам равно {matrix[x,y]}");
         

}






int m = ReadNumber("Введите количество строк");
int n = ReadNumber("Введите количество столбцов");
int[,] matr = GetMatrix(m, n);
PrintMatrix(matr);

int x = ReadNumber("Введите индекс искомого элемента по строке");
int y = ReadNumber("Введите индекс искомого элемента по столбцу");

FindElements(matr, x, y);