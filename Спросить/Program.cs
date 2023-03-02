// Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

//   i =012345678
// num =0 1 -1 2 
// i=1, value=0_,  0>0, result=0
// i=3, value=1_,  1>0, result=1
// i=6, value=-1_, -1>0, result=1
// i=8, value=2,   2>0, result=2


int PositiveNumbers(string numbers)
{
    int result = 0;
    int value = 0;
    
    for(int i = 0; i < numbers.Length; i++)
    {                                                     
        if (numbers[i] == ' ')                                   
        {
            if(value > 0)
            {
                result ++;
            }  
            value = 0;                                                       
        }                                                        
        else                                                    
        {
            if (value < 0)
            {
                value = -1;
            }
            else
            {
                if(numbers[i] == '.'| numbers[i] == ','| numbers[i] == ':'| numbers[i] == ';') 
                {
                value = value + 0;
                }
                else
                {
                value += (Convert.ToInt32(numbers[i]) - 48); //????
                Console.WriteLine(value);
                }
            }                                               
        }
    }
return result;
}

Console.WriteLine("Введите числа через пробел");
string numbers = Console.ReadLine();

if(numbers[numbers.Length - 1] != ' ')
{
    numbers = numbers + ' ';
}

int coll = PositiveNumbers(numbers);

Console.WriteLine("Количество введеных целых чисел больше 0 = " + coll);
