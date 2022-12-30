// Выводить двумерный массив [m , n]
// где каждый элемент равен суммк своих [m , n]

Console.WriteLine("Задайте число строк массива m");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте число строк массива n");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[rows, columns];

for (int i = 0; i < matrix.GetLength(0); i++)
{
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
    matrix[i, j] = i + j;
    Console.Write(matrix[i, j] + " ");
  }
  Console.WriteLine();
}
