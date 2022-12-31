// Найти сумму элементов по главной диагонали
// в рандомном массиве m, n c элементами в диапазоне 1-10

Console.WriteLine("Задайте число строк массива m");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте число строк массива n");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] matrix = new int[rows, columns];
int sum = 0;

for (int i = 0; i < matrix.GetLength(0); i++)
{
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
    matrix[i, j] = new Random().Next(10);
    Console.Write(matrix[i, j] + " ");

    if(i == j)sum = sum + matrix[i, j];
  }
  Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine(sum);
