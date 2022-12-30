// Выводить рандомный двумерный массив [m , n]
// с целыми положительными числами в диапазоне 1-99

Console.WriteLine("Задайте число строк массива m");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте число строк массива n");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[rows, columns];

for (int i = 0; i < matrix.GetLength(0); i++)
{
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
    matrix[i, j] = new Random().Next(100);
    Console.Write(matrix[i, j] + " ");
  }
  Console.WriteLine();
}


