// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] CreatArray(int m, int n, int min, int max)
{
    int[,] CrArray = new int[m, n];
    for (int i = 0; i < CrArray.GetLength(0); i++)
    {
        for (int j = 0; j < CrArray.GetLength(1); j++)
        {
            CrArray[i, j] = new Random().Next(1, 10);
        }
    }
    return CrArray;
}

void SortArray(int[, ] Arr)
{
    int temp = 0;
    for (int i = 0; i < Arr.GetLength(0); i++)
    {
        for (int j = 0; j < Arr.GetLength(1); j++)
        {
            for (int k = 0; k < Arr.GetLength(1) -1; k++)
            {
                if( Arr[i, k] < Arr[i,k +1])    
                {
                    temp = Arr[i, k];
                    Arr[i, k] = Arr[i, k +1];
                    Arr[i, k +1 ] = temp;
                }
            }    
        }
    }
    for (int i = 0; i < Arr.GetLength(0); i++)
    {
        for (int j = 0; j < Arr.GetLength(1); j++)
        {
            Console.Write( Arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}


void PrintArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write(Array[i,j] + " ");
        }
        Console.WriteLine();
    }
}


int[,] myArray = CreatArray(5, 5, 1, 10);
PrintArray(myArray);
Console.WriteLine();
SortArray(myArray);



// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

 int[,] CreatArray(int m, int n, int min, int max)
{
    int[,] CrArray = new int[m, n];
    for (int i = 0; i < CrArray.GetLength(0); i++)
    {
        for (int j = 0; j < CrArray.GetLength(1); j++)
        {
            CrArray[i, j] = new Random().Next(1, 10);
        }
    }
    return CrArray;
}

void MinSumArray(int [,] Arr)
{
    int min = 0;
    int result = 0;
    int row = 0;
    for (int i = 0; i < Arr.GetLength(0); i++)
    {
        int summ = 0;
        for (int j = 0; j < Arr.GetLength(1); j++)
        {
            summ += Arr[i, j];
        }
            if(summ <= min)
            {
                result = summ;
                row = i;
            }
            min = summ;
            Console.Write(summ + " ");     
    }
    Console.WriteLine();
    Console.WriteLine($"Наименьшая сумма элементов {result} ");
    Console.WriteLine($"Строка снаименьшей суммой элементов {row} ");
    Console.WriteLine();
}

void PrintArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write(Array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

Console.Clear();
int[,] myArr = CreatArray(4, 5, 1, 10);
PrintArray(myArr);
Console.WriteLine();
MinSumArray(myArr);


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] GetMatrixOne(int rows, int columns, int min, int max)
{
    int [,] Matrix = new int [rows, columns];
    for (int i = 0; i < Matrix.GetLength(0); i++)
    {
        for (int j = 0; j < Matrix.GetLength(1); j++)
        {
            Matrix[i,j] = new Random().Next(min, max);
        }
    }
    return Matrix;
}

int[,] GetMatrixTwo(int Rows, int Columns, int Min, int Max)
{    
    int [,] Matr = new int [Rows, Columns];
    for (int k = 0; k < Matr.GetLength(0); k++)
    {
        for (int p = 0; p < Matr.GetLength(1); p++)
        {
            Matr[k,p] = new Random().Next(Min, Max);
        }
    }
    return Matr;
}

void PrintGetMatrixOne(int [,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write(Array[i,j] + " ");
        }
        Console.WriteLine();
    }
}
void PrintGetMatrixTwo(int [,] Arr)
{
    for (int i = 0; i < Arr.GetLength(0); i++)
    {
        for (int j = 0; j < Arr.GetLength(1); j++)
        {
            Console.Write(Arr[i,j] + " ");
        }
        Console.WriteLine();
    }
}

void ProductOfArrays(int [,] OneArray, int [,] TwoArray)
{
    int [, ] ThreeArray = new int [OneArray.GetLength(0), TwoArray.GetLength(1)];
    if (OneArray.GetLength(1) == TwoArray.GetLength(0))   
    for (int i = 0; i < OneArray.GetLength(0); i++)
    {
        for (int j = 0; j < TwoArray.GetLength(1); j++)
        {
            for (int k = 0; k < TwoArray.GetLength(0); k++)
            {
                ThreeArray[i, j] += OneArray[i, k] * TwoArray[k, j];
            }
            Console.Write(ThreeArray[i, j] + " ");
        }
        Console.WriteLine();
    }
    else Console.WriteLine(" Размерность матриц не совпадает");
}

Console.Clear();
int[,] MyArrayOne = GetMatrixOne(3, 3, 1, 5);
PrintGetMatrixOne(MyArrayOne);
Console.WriteLine();
int[,] MyArrayTwo = GetMatrixTwo(3, 3, 1, 5);
PrintGetMatrixTwo(MyArrayTwo);
Console.WriteLine();
ProductOfArrays(MyArrayOne, MyArrayTwo);



// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

void Array3D(int[,,] Array3D)
{
    int[] temp = new int[Array3D.GetLength(0) * Array3D.GetLength(1) * Array3D.GetLength(2)];
    int number;
    for (int i = 0; i < temp.GetLength(0); i++)
    {
        temp[i] = new Random().Next(10, 99);
        number = temp[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (temp[i] == temp[j])
                {
                    temp[i] = new Random().Next(10, 99);
                    j = 0;
                    number = temp[i];
                }
            }
        }
    }
    int  count = 0;
    for (int x = 0; x < Array3D.GetLength(0); x++)
    {
        for (int y = 0; y < Array3D.GetLength(1); y++)
        {
            for (int z = 0; z < Array3D.GetLength(2); z++)
            {
                Array3D[x, y, z] = temp[count];
                count++;
            }
        }
    }
}

void PrintMyArray3D (int[,,] Array)
{
  for (int i = 0; i < Array.GetLength(0); i++)
    {
      for (int j = 0; j < Array.GetLength(1); j++)
      {
        for (int k = 0; k < Array.GetLength(2); k++)
        {
          Console.Write(Array[i, j, k] + " ");
        }
        Console.WriteLine();
      }
      Console.WriteLine();
    }
}

 Console.WriteLine("Введите размер массива: x, y, z");
Console.Write("Введите Х: ");
int X = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите У: ");
int Y = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите Z: ");
int Z = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int [,,] Arr3D = new int[X, Y, Z];
Array3D(Arr3D);
PrintMyArray3D(Arr3D);


//  Задача 62: Заполните спирально массив 4 на 4.

int n = 4;
int[,] array = new int[n, n];

int num = 1;
int i = 0;
int j = 0;

while (num <= array.GetLength(0) * array.GetLength(1))
{
  array[i, j] = num;
  num++;
  if (i <= j + 1 && i + j < array.GetLength(1) - 1)    // вправо
    j++;  
  else if (i < j && i + j >= array.GetLength(0) - 1)  // вниз
    i++;  
  else if (i >= j && i + j > array.GetLength(1) - 1)  // влево
    j--;
  else
    i--;  // вверх
}

WriteArray(array);

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}





