Console.WriteLine("Введите первую координату первого числа");
double x1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите вторую координату первого числа");
double y1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите третью координату первого числа");
double z1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите первую координату второго числа");
double x2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите вторую координату второго числа");
double y2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите третью координату второго числа");
double z2 = double.Parse(Console.ReadLine());

double otv = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console.WriteLine($"Расстояние между точками равно {otv}");