Console.WriteLine("Введите пятизначное число ");
int number = Convert.ToInt32 (Console.ReadLine());

int n1 = number / 10000;
int n2 = (number / 1000) % 10;
int n4 = (number / 10) % 10;
int n5 = number % 10;

if (number <= 0)
    Console.WriteLine("Вы ввели некорректное число");
else
{
    int quantity = Convert.ToInt32(Math.Truncate(Math.Log10(number)));
    if (quantity != 4)
        Console.WriteLine("Вы ввели не пятизначное число");
    else if (n1 == n5 && n2 == n4)
            Console.WriteLine("Является палиндромом");
        else
            Console.WriteLine("Не является палиндромом");
}