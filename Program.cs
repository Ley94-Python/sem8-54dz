// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки 
// двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
int[,] FillMatrix(int rows, int columns)
{
int[,] matrix = new int [rows, columns];
for(int i = 0; i < matrix.GetLength(0); i++)
{
for(int j = 0; j < matrix.GetLength(1); j++)
{
matrix[i,j] = new Random().Next(0,10);
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
Console.Write(matrix[i,j] + " ");
}
Console.WriteLine();
}
}
Console.WriteLine("Ведите значения двумерного массива: ");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int [,] matrix = FillMatrix(m,n);
PrintMatrix(matrix);
for (int i = 0; i < matrix.GetLength(0); i++) 
{
    for (int j = matrix.GetLength(1) - 1; j > 0; j--)
    {

        for (int k = 0; k < j; k++) // k - номер текущей строки
            {
            if (matrix[i, k] < matrix[i, k + 1]) // если  элемент тек.строки меньше чем след.элемент строки
                {
                 int temp = matrix[i, k]; 
                 matrix[i, k] = matrix[i, k + 1];
                matrix[i, k + 1] = temp; // записываем больший элемент строки на место первого элемента - тот кот.был меньше
                }
            }
    }
    Console.WriteLine();
}

PrintMatrix(matrix);