// Задача 1 
// Реализовать перемешивание массива
// 1. Создать массив
// 2. Распечатать массив
// 3. Заполненить массив
// 4. Перемешать массив
// 5. Вывести перемешанный массив

Console.WriteLine("Решение задачи на перемешивание массива");

int[] CreateArray(int length)
{
  return new int[length];
}

void Print(int[] array)
{
  Console.WriteLine("Полученный массив: ");
  int size = array.Length;
  int index = 0;
  while (index < size)
  {
    Console.Write(array[index] + " ");
    index ++;
  }
  Console.WriteLine();
}

void FillArray(int[] array)
{
    int size = array.Length;
    int index = 0;
    while (index < size)
    {
        array[index] = index; // new Random().Next(1, 10);
        index++;
    }
}

int Resort(int[] array)
{
    int size = array.Length;
    int index = 0;

    while(index < size - 1)
    {
    int help = 0;
    int rand = new Random().Next(1, 3);

    help = array[index];
    array[index] = array[size - rand];
    array[size - rand] = help;

    index++;
    }
    
    return array[index];
}

int[] arr = CreateArray(10);
FillArray(arr);
Print(arr);
Resort(arr);
Print(arr);


//Задача 2
//Дан массив: наполненый числами от 1 до N
//Задача: сколько раз какое число встречается
//1 3 1 2 1 2 4 5 1 2 5 4

//1 - 4р
//2 - 3р
//3 - 1р
//4 - 2р
//5 - 2р

// 1.    Создать массив
// 2.    Распечатать массив
// 3.    Заполнить массив числами от 1 до N
// 3.1   Попросить пользователя ввести длину массива L
// 3.2   Попросить пользователя ввести число N
// 3.3   Заполнить массив числами от 1 до N по длине массива L
// 4     Найти кол-во чисел в массиве
// 4.1   Найти кол-во чисел для одного числа
// 4.2   Найти кол-во чисел для каждого числа до N

Console.WriteLine("Решение задачи на подсчет элементов в массиве");

int LongArray()
{
Console.WriteLine("Введите длину массива: ");
int L = Convert.ToInt32(Console.ReadLine());
return L;
}

int FordemN()
{
Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
return N;
}

void FillArray_N(int[] array)
{
    int N = FordemN();
    
    int size = array.Length;
    int index = 0;
    
    while (index < size)
    {
        array[index] = new Random().Next(1, N+1);
        index++;
    }
}

int QuantityNumber(int[] array, int find)
{
    int col = 0;
    int size = array.Length;
    int index = 0;

    while(index < size)
    {
        if(array[index] == find)
        {
            col++;
        }
        index++;
    }
    return col;
}

void QuantityIndex(int[] array)
{
    int N = FordemN();

    int find = 1;

    while(find <= N)
    {    
        int pos = QuantityNumber(array, find);
        Console.Write("Количество чисел: " + find);
        Console.WriteLine(" = " + pos);
        find++;
    }
}

int L1 = LongArray();
int[] arr1 = CreateArray(L1);

FillArray_N(arr1);
Print(arr1);
QuantityIndex(arr1);


//Задача 19
//Напишите программу, которая принимает на вход пятизначное число 
//и проверяет, является ли оно палиндромом.

//14212 -> нет
//12821 -> да
//23432 -> да

// 1.  Ввести значение
// 1.1 Проверить значение: пятизначное число или нет
// 2.  Перевернуть введеное значение
// 3.  Сравнить введенное значение и перевернутое значение на палиндром
// 4.  Вывести сообщение о проверке на палиндром

Console.WriteLine("Решение задачи на палиндром");

void FiveDigitNumber (int number)
{
if (number < 10000 || number > 99999)
{
    Console.WriteLine("Вы ввели не пятизначное число, повторите ввод");
    System.Environment.Exit(number);
}
}

void ComparingArrays(string array1, string array2)
{
if (array1 == array2)
{
Console.WriteLine("Это полиндром");
}
else
{
Console.WriteLine("Это не полиндром");
}
}

Console.WriteLine("Введите значение для проверки на палиндром: ");
string pal = Convert.ToString(Console.ReadLine());

int prov = Convert.ToInt32(pal);
FiveDigitNumber(prov);

char [] arrays = pal.ToCharArray();

string arrays1 = string.Concat(arrays);

Array.Reverse(arrays);

string arrays2 = string.Concat(arrays);

ComparingArrays(arrays1, arrays2);


//Задача 21
//Напишите программу, которая принимает на вход координаты 
//двух точек и находит расстояние между ними в 3D пространстве.

//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

// 1. Запросить координаты точки А
// 2. Запросить координаты точки В
// 3. Рассчитать расстояние между этими точками в 3D пространстве
// 4. Вывести полученное расстояние

Console.WriteLine("Решение задачи на нахождение расстояния между двумя точками в 3D пространстве");

int Coordinate (int X)
{
Console.WriteLine("Введите координату");
int s = Convert.ToInt32(Console.ReadLine());
return s;
}

void CoordinateA_3D(int [] array)
{
array[0] = Coordinate(0);
array[2] = Coordinate(0);
array[4] = Coordinate(0);
Console.WriteLine("Координата точки А: (" + (array[0]) + ", " + (array[2]) + ", " + (array[4]) + ")");
}

void CoordinateB_3D(int [] array)
{
array[1] = Coordinate(0);
array[3] = Coordinate(0);
array[5] = Coordinate(0);
Console.WriteLine("Координата точки B: (" + (array[1]) + ", " + (array[3]) + ", " + (array[5]) + ")");
}

double Rosstoyan_3D (int [] array)
{
    double S_3D = Math.Sqrt((array[1] - array[0]) * 
    (array[1] - array[0]) + (array[3] - array[2]) * 
    (array[3] - array[2]) + (array[5] - array[4]) * 
    (array[5]-array[4]));
    return S_3D;
}

int[] array = new int[6];
CoordinateA_3D(array);
CoordinateB_3D(array);
double S_3D = Rosstoyan_3D(array);
Console.WriteLine(S_3D);


//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт 
//таблицу кубов чисел от 1 до N.

//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

// 1. Запросить число N
// 2. Посчитать кубы от 1 до N
// 3. Вывести кубы каждого числа

Console.WriteLine("Решение задачи на нахождение кубов чисел");

void NumberInCube(int num)
{
int num1 = 1;
while(num1 <= num)
{
    int kub = num1 * num1 * num1;
    Console.Write(kub + ": ");
    num1++;
}
}

int cub = FordemN();
NumberInCube(cub);