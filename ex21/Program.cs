Console.WriteLine("Введите координату x точки A");
int ax = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите координату y точки A");
int ay = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите координату z точки A");
int az = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите координату x точки B");
int bx = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите координату y точки B");
int by = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите координату z точки B");
int bz = Convert.ToInt32 (Console.ReadLine());

double distance = Math.Round(Math.Sqrt(Math.Pow(ax - bx, 2) + Math.Pow(ay - by, 2) + Math.Pow(az - bz, 2)), 2);
Console.WriteLine($"Расстояние между двумя точками равно {distance}");