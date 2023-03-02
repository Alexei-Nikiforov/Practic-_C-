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


int PositiveNumbers(string Numbers)
{
    int result = 0;
    int val = 0;
    
    for(int i = 0; i < Numbers.Length; i++)
    {                                                     
        if (Numbers[i] == ' ')                                   
        {
            if(val > 0)
            {
                result ++;
            }  
            val = 0;                                                       
        }                                                        
        else                                                    
        {
            if (val < 0)
            {
                val = -1;
            }
            else
            {
            val += (Convert.ToInt32(Numbers[i]) - 48);
            Console.WriteLine(val);
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

int Coll = PositiveNumbers(numbers);

Console.WriteLine("Количество введеных целых чисел больше 0 = " + Coll);
