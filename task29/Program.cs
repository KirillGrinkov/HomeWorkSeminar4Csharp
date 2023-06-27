// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе


Console.Clear();


Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное значение массива: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное значение массива: ");
int max = Convert.ToInt32(Console.ReadLine());


int[] randomArray = new int[size]; 



 for (int i = 0; i < randomArray.Length; i++)
    {
     randomArray[i] = Rand ();

     Console.Write($"{randomArray[i]} ,"); 
    }

 int Rand()
 {
     return new Random().Next(min,max); 
 }