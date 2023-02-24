// Напишите программу, которая принимает на вход пятизначное число и проверяет,
//  является ли оно палиндромом. Проверка без применения строк
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int Prompt(string message)
{
    Console.Write($"{message} -> ");
    return Convert.ToInt32(Console.ReadLine());
}

int Counter(int number)
{
    int count = 0;
    if (number < 0) number = number * -1;
    while (number != 0)
    {
        number /= 10;
        count++;
    }
    return count;
}
void Validate(int number, int longnumber)
{
    bool test = true;
    int[] array = new int[longnumber];    
    for (int i = 0; i < longnumber; i++)    
    {
        array[i] = number % 10;
        number /= 10;
    }
    for (int j = 0; j < longnumber / 2; j++)
    {        
        if (array[j] == array[longnumber - 1])
        {
            longnumber--;
            test = true;         
        }
        else
        {                        
            test = false;            
        }    
        
    }
    if (test) 
        {
            System.Console.WriteLine("Число является палиндромом.");            
        }
        else
        {
            System.Console.WriteLine("Число не является палиндромом.");
        }
}

int enternumber = Prompt("Введите число");
int numberlong = Counter(enternumber);
Validate(enternumber, numberlong);




