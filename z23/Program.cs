Console.WriteLine("Введите первое число");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int m = int.Parse(Console.ReadLine());
for (int i = n; i <= m; i++){
    Console.Write($"{Math.Pow(i,3)} ");
}