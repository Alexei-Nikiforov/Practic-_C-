// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// Алгоритм
// 1. Создать трехмерный массив
// 2. Заполнить трехмерный массив
// 3. Заполнить трехмерный массив двухзначными числами
// 4. Проверить получившийся трехмерный массив на повторяемые значения
// 5. Распечатать построчно значения массива, добавляя индексы каждого элемента

int [, ,] CreateMatrix3D(int line, int column, int depth)
{
    return new int[line, column, depth];
}

void FillMatrix3D(int[, ,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i,j,k] = new Random().Next(10,15);
            }
        }
    }
}

void CheckingDuplicateValues(int[, ,] matrix)
{
    int dob = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                if(matrix[i,j,k] == matrix[i,j,1])
                    {
                        matrix[i,j,1] = 20 + dob;
                        dob++;
                    }
                if(matrix[i,j,k] == matrix[i,1,k])
                    {
                        matrix[i,1,k] = 40 + dob;
                        dob++;
                    }
                if(matrix[i,j,k] == matrix[1,j,k])
                    {
                        matrix[1,j,k] = 60 + dob;
                        dob++;
                    }
            }
        }
    }
}

void PrintMatrix3D(int[, ,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k]} ["+ i +"];["+ j +"];["+ k +"];");
                Console.WriteLine();
            }
        }
    }
}

Console.WriteLine("Введите длину трехмерного массива: ");
int Line3D = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите высоту трехмерного массива: ");
int Column3D = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите глубину трехмерного массива: ");
int Depth3D = Convert.ToInt32(Console.ReadLine());

int [, ,] Matrix3D = CreateMatrix3D(Line3D, Column3D, Depth3D);
FillMatrix3D(Matrix3D);

Console.WriteLine("Получился трехмерный массив:");
PrintMatrix3D(Matrix3D);
Console.WriteLine();
CheckingDuplicateValues(Matrix3D);
Console.WriteLine("Получился трехмерный массив с неповторяющимися элементами:");
PrintMatrix3D(Matrix3D);
