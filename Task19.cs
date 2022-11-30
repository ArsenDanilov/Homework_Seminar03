// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом
/*
void Task19()
{
    Console.WriteLine("Введите число");
    int number = Convert.ToInt32(Console.ReadLine());

    if(number < 10000 || number > 99999)
    {
        Console.WriteLine("Вы ввели не пятизначное или отрицательное число");
    }
    
    else
    {
        string Number = Convert.ToString(number);
        int [] Array = new int[Number.Length];
    
        for(int i = 0; i < Number.Length; i++)
        {
            Array[i] = Convert.ToInt32(Number[i]);
        }
        if (Number[0] == Number[4] && Number[1] == Number[3])
        {
            Console.WriteLine("Число является палиндромом");
        }
        else
        {
            Console.WriteLine("Число не является палиндромом");
        }
    }
    
}
Task19();
*/