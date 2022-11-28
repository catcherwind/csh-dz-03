// Это самое кривое решение в моей жизни. Количество магических чисел зашкаливает

Console.WriteLine("Введите пятизначное число");
int n = int.Parse(Console.ReadLine());
int step = 4; 
int p = 1;
int otvet = 1;
for (int i = 0; i < 3; i++){
    if (Convert.ToInt32(n/Math.Pow(10,step)) == n%10){
        step -= 2;
        n /= 10;
        p = 1;
        while (n / p > n%10) p *= 10;
        n %= p;
    }
    else {
        otvet = 0;
        break;
    }
}
if (otvet == 0)
    Console.WriteLine("Число не палиндром");
else
    Console.WriteLine("Число палиндром");