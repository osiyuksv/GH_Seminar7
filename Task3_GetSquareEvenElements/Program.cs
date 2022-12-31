// В рандомном двумерный массив [m , n] с элементами
// в диапазоне 1-10 заменить все элементы
// с обеими чётными индексами на их квадраты

Console.WriteLine("Задайте число строк массива m");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте число строк массива n");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[rows, columns];

for (int i = 0; i < matrix.GetLength(0); i++)
{
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
    matrix[i, j] = new Random().Next(10);
    Console.Write(matrix[i, j] + " ");
  }
  Console.WriteLine();
}

Console.WriteLine();

for (int i = 0; i < matrix.GetLength(0); i++)
{
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
    if (i % 2 == 0 & j % 2 == 0)
    {
      matrix[i, j] = matrix[i, j] * matrix[i, j];
      Console.Write(matrix[i, j] + " ");
    }
    else Console.Write(matrix[i, j] + " ");
  }
  Console.WriteLine();
}