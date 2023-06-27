// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе

Console.Clear();

int num = GetNumberFromUser("Введите целое число : ", "Ошибка ввода!");


int GetNumberFromUser(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        if(int.TryParse(Console.ReadLine(), out int userNumber))
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

int SumNumber(int num)
{
    int size = Convert.ToString(num).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < size; i++)
    {
        advance = num - num % 10;
        result = result + (num - advance);
        num = num / 10;
    }
   return result;
}

int sumNumber = SumNumber(num);
Console.WriteLine($"Сумма цифр = {sumNumber} ");
