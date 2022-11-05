//Напишите программу, которая принимает на вход координаты 
//двух точек и находит расстояние между ними в N-мерном пространстве. 
//Сначала задается N с клавиатуры, потом задаются координаты точек.

int[] fillCoord(int lenght)
{
    int[] array = new int[lenght];
    for(int i = 0; i < lenght; i++)
    {
        Console.WriteLine($"Введите {i + 1} координату точки");
        array[i] = Convert.ToInt32 (Console.ReadLine());
    }
    return array;
}

double DistanceBetweenPoints(int[] array1, int[] array2)
{
    double SumOfSquares = 0;
    for(int i = 0; i < array1.Length; i++)
        SumOfSquares = SumOfSquares + Math.Pow(array1[i] - array2[i], 2);
    double result = Math.Round(Math.Sqrt(SumOfSquares), 2);
    return result;   
}

Console.WriteLine("Введите количество координат точек A и B");
int n = Convert.ToInt32 (Console.ReadLine());

int[] arrayPointA = fillCoord(n);
int[] arrayPointB = fillCoord(n);
Console.WriteLine($"Расстояние между точками A и B в {n}-мерном пространстве равно {DistanceBetweenPoints(arrayPointA, arrayPointB)}");
