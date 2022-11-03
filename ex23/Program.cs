//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите натуральное число ");
int number = Convert.ToInt32 (Console.ReadLine());
int i = 1;

if (number <= 0)
    Console.WriteLine("Вы ввели некорректное число");
else 
    for (i = 1; i <= number; i++)
    {
        Console.WriteLine(Math.Pow(i, 3));
    }
